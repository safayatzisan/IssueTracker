﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using IssueTracker.Data;
using IssueTracker.Data.Models;
using IssueTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Controllers
{
    public class IssueLogController : Controller
    {
        private readonly IIssueLog _issueLogService;
        private readonly IProject _projectService;
        private readonly INotification _notificationService;
        private readonly IInvolvedPerson _involvedPersonService;
        private static UserManager<ApplicationUser> _userManager;

        public IssueLogController(IIssueLog issueLogService,IProject projectService, UserManager<ApplicationUser> userManager, INotification notificationService, IInvolvedPerson involvedPersonService)
        {
            _issueLogService = issueLogService;
            _projectService = projectService;
            _userManager = userManager;
            _notificationService = notificationService;
            _involvedPersonService = involvedPersonService;
        }

        [Authorize]
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var issueLogs = _issueLogService.GetAll().Where(x => x.IsComplete == false && x.EntryBy.Id == userId).OrderByDescending(x => x.AssignDate).ToList();
            var model = BuildIssueLogIndex(issueLogs, false);
            return View(model);
        }

        public IActionResult IndexForAll()
        {
            var issueLogs = _issueLogService.GetAll().Where(x => x.IsComplete == false).OrderByDescending(x => x.AssignDate).ToList();
            var model = BuildIssueLogIndex(issueLogs, true);
            return View("Index",model);
        }

        [Authorize]
        public IActionResult Create()
        {
            var projects = BuildProjectList();
            var companies = BuildCompanyList();
            var model = new IssueLogListingModel
            {
                Projects = projects,
                Companies = companies,
                IssueDate = null,
                Priority = null,
                IssueType = null,
                ApplicationUserListingModels = BuildApplicationUserList()
            };

            return View(model);
        }

        [HttpPost]
        public JsonResult Create([FromBody]IssueLogListingModelForAjax issueLogListingModel)
        {
            if (ModelState.IsValid)
            {
                List<string> involvedPersonIds = new List<string>();
                if(!string.IsNullOrEmpty(issueLogListingModel.IssueLogInvolvedPersonIds))
                    involvedPersonIds = issueLogListingModel.IssueLogInvolvedPersonIds.Split(',').ToList();
                var userId = _userManager.GetUserId(User);
                var user = _userManager.FindByIdAsync(userId).Result;
                var involvedPersons = new List<ApplicationUser>();
                if(involvedPersonIds.Count() > 0)
                {
                    involvedPersons = _userManager.Users.Where(x => involvedPersonIds.Contains(x.Id)).ToList();
                }                    
                involvedPersons.Add(user);
                var issueLog = BuildIssueLogForCreate(issueLogListingModel, user, involvedPersons);
                _issueLogService.Create(issueLog);
                foreach(var p in issueLog.IssueLogInvolvedPersons.Where(x => x.InvolvedPerson.Id != user.Id))
                {
                    var notification = new Notification
                    {
                        UserFrom = user.Id,
                        UserFromImage = user.ProfileImageUrl,
                        UserTo = p.InvolvedPerson.Id,
                        Header = issueLog.Project.Name + "(" + issueLog.Project.Company.Name + ")",
                        Message = issueLog.Header,
                        IsRead = false
                    };
                    _notificationService.Create(notification);
                }
                //var smtpClient = new SmtpClient
                //{
                //    Host = "smtp.gmail.com", // set your SMTP server name here
                //    Port = 587, // Port 
                //    EnableSsl = true,
                //    Credentials = new NetworkCredential("zisan94268@gmail.com", "SBsb@@##942681992fuckyouGetVirusSBsb@@##942681992fuckyou")
                //};

                //using (var message = new MailMessage("zisan94268@gmail.com", "zisan_cse_mbstu@hotmail.com")
                //{
                //    Subject = "Subject",
                //    Body = "Body"
                //})
                //{
                //    smtpClient.SendMailAsync(message);
                //}
                return Json(new
                {
                    redirectTo = Url.Action("Index", "IssueLog")
                });
            }
            return Json(new
            {
                redirectTo = Url.Action("Index", "IssueLog"),
            });
        }

        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var issueLog = _issueLogService.GetById((int)id);
            var model = BuildIssueLogForEdit(issueLog);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [Authorize]
        public IActionResult Complete(int id)
        {
            var issueLog = _issueLogService.GetById((int)id);
            issueLog.IsComplete = true;
            foreach(var ip in issueLog.IssueLogInvolvedPersons)
            {
                ip.IsComplete = true;
            }
            _issueLogService.Complete(issueLog);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public JsonResult Edit([FromBody]IssueLogListingModelForAjax issueLogListingModel)
        {
            if (ModelState.IsValid)
            {
                List<string> involvedPersonIds = new List<string>();
                if (!string.IsNullOrEmpty(issueLogListingModel.IssueLogInvolvedPersonIds))
                    involvedPersonIds = issueLogListingModel.IssueLogInvolvedPersonIds.Split(',').ToList();
                var userId = _userManager.GetUserId(User);
                var user = _userManager.FindByIdAsync(userId).Result;
                var involvedPersons = new List<ApplicationUser>();
                involvedPersons.Add(user);
                if (involvedPersonIds.Count() > 0)
                {
                    var persons = _userManager.Users.Where(x => involvedPersonIds.Contains(x.Id)).ToList();
                    involvedPersons.AddRange(persons);
                }
                
                var issueLog = BuildIssueLogForCreate(issueLogListingModel, user, involvedPersons.Distinct());
                issueLog.Id = issueLogListingModel.Id;
                var il = _issueLogService.GetById(issueLog.Id);
                bool isAllComplted = false;
                bool.TryParse(issueLogListingModel.IsAllCompletedExceptOwn, out isAllComplted);
                foreach (var item in issueLog.IssueLogInvolvedPersons)
                {
                    if (item.InvolvedPerson.Id == _userManager.GetUserId(User))
                    {
                        if (isAllComplted)
                        {
                            item.IsComplete = true;
                            item.HoursToComplete = issueLogListingModel.WorkHour;
                            item.SubmitDate = DateTime.Now;
                        }
                    }
                    else
                    {
                        var searchItemFromInvolvedPerson = il.IssueLogInvolvedPersons.Where(x => x.InvolvedPerson.Id == item.InvolvedPerson.Id).FirstOrDefault();
                        item.HoursToComplete = searchItemFromInvolvedPerson != null ? searchItemFromInvolvedPerson.HoursToComplete : 0;
                        item.ExpectedHour = searchItemFromInvolvedPerson != null? searchItemFromInvolvedPerson.ExpectedHour : 0;
                        item.ReceiveDate = searchItemFromInvolvedPerson != null? searchItemFromInvolvedPerson.ReceiveDate : DateTime.MinValue;
                        item.IsComplete = searchItemFromInvolvedPerson != null? searchItemFromInvolvedPerson.IsComplete : false;
                        item.SubmitDate = searchItemFromInvolvedPerson != null ? searchItemFromInvolvedPerson.SubmitDate : DateTime.MinValue;
                    }                    
                }
                _issueLogService.Edit(issueLog);

                return Json(new
                {
                    redirectTo = Url.Action("Index", "IssueLog")
                });
            }
            return Json(new
            {
                redirectTo = Url.Action("Index", "IssueLog"),
            });
        }

        public IActionResult FindProject(int companyId)
        {
            var projects = _projectService.GetAll()
                .Where(x => x.Company.Id == companyId)
                .Select(x => new
                {
                    id = x.Id,
                    name = x.Name
                }).ToList();
            return new JsonResult(projects);
        }

        public IActionResult FindInvolvedPerson(string issueInvolvedPersonId)
        {
            var users = _userManager.Users.Include(x => x.Designation);
            var user = users.Where(x => x.Id == issueInvolvedPersonId).FirstOrDefault();
            var issueInvolvedPerson = new
            {
                id = user.Id, 
                name = user.UserName, 
                emailAddress = user.Email,
                designation = user.Designation != null ? user.Designation.Name : ""
            };
            return new JsonResult(issueInvolvedPerson);
        }        

        [Authorize]
        public IActionResult Delete(int id)
        {
            _issueLogService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private IssueLogListingModel BuildIssueLogForEdit(IssueLog issueLog)
        {
            var model = new IssueLogListingModel
            {
                Id = issueLog.Id,
                CompanyId = issueLog.Project.Company.Id,
                CompanyName = issueLog.Project.Company.Name,
                ProjectId = issueLog.Project.Id,
                ProjectName = issueLog.Project.Name,
                IssueDate = issueLog.IssueDate,
                Header = issueLog.Header,
                Body = issueLog.Body,
                Note = issueLog.Note,
                EntryBy = issueLog.EntryBy,
                AssignBy = issueLog.AssignBy,
                AssignDate = issueLog.AssignDate,
                AssignRemarks = issueLog.AssignRemarks,
                IssueLogInvolvedPersons = BuildIssueLogInvolvedPerson(issueLog.IssueLogInvolvedPersons),
                Priority = issueLog.Priority,
                TaskHour = issueLog.TaskHour,
                IssueType = issueLog.IssueType,
                ApplicationUserListingModels = BuildApplicationUserList(),
                IsAllCompletedExceptOwn = issueLog.IssueLogInvolvedPersons.Where(y => y.InvolvedPerson.Id != _userManager.GetUserId(User) && y.IsComplete).ToList().Count == (issueLog.IssueLogInvolvedPersons.Count() - 1)
            };
            return model;
        }        

        private IEnumerable<ApplicationUserListingModel> BuildApplicationUserList()
        {
            var currentUserId = _userManager.GetUserId(User);

            var users = _userManager.Users.AsEnumerable().Where(x => x.Id != currentUserId);
            var model = users.Select(x => new ApplicationUserListingModel
            {
                Id = x.Id,
                Name = x.UserName
            });
            return model;
        }

        private IEnumerable<ProjectListingModel> BuildProjectList()
        {
            var projects = _projectService.GetAll();
            var model = projects.Select(x => new ProjectListingModel
            {
                Id = x.Id,
                Name = x.Name,
                CompanyId = x.Company.Id
            });
            return model;
        }

        private IssueLog BuildIssueLogForCreate(IssueLogListingModelForAjax model, ApplicationUser applicationUser, IEnumerable<ApplicationUser> involvedPersons)
        {
            bool isAllComplted = false;
            bool.TryParse(model.IsAllCompletedExceptOwn, out isAllComplted);
            var issueLog = new IssueLog
            {
                Project = BuildProject(int.Parse(model.ProjectId)),
                IssueDate = DateTime.Parse(model.IssueDate),
                Header = model.Header,
                Body = model.Body,
                Note = model.Note,
                EntryBy = applicationUser,
                AssignDate = DateTime.Now,
                IssueLogInvolvedPersons = BuildIssueLogInvolvedPerson(involvedPersons, isAllComplted),
                Priority = (EnumIssuePriority)int.Parse(model.Priority),
                TaskHour = double.Parse(model.TaskHour),
                IssueType = (EnumIssueType)int.Parse(model.IssueType)                
            };

            return issueLog;
        }


        private IEnumerable<IssueLogInvolvedPerson> BuildIssueLogInvolvedPerson(IEnumerable<ApplicationUser> involvedPersonsModel, bool isAllCompleted)
        {
            var involvedPersons = new List<IssueLogInvolvedPerson>();
            foreach (var ip in involvedPersonsModel)
            {
                var involvedPerson = new IssueLogInvolvedPerson();
                involvedPerson.InvolvedPerson = new ApplicationUser();
                involvedPerson.InvolvedPerson.Id = ip.Id;
                involvedPersons.Add(involvedPerson);
            }            
            return involvedPersons;
        }

        private IEnumerable<IssueLogInvolvedPersonListingModel> BuildIssueLogInvolvedPerson(IEnumerable<IssueLogInvolvedPerson> involvedPersons)
        {
            var model = new List<IssueLogInvolvedPersonListingModel>();
            foreach (var ip in involvedPersons)
            {
                var person = new IssueLogInvolvedPersonListingModel
                {
                    Id = ip.Id,
                    UserId = ip.InvolvedPerson.Id,
                    UserName = ip.InvolvedPerson.UserName,
                    EmailAddress = ip.InvolvedPerson.Email,
                    Designation = ip.InvolvedPerson.Designation != null ? ip.InvolvedPerson.Designation.Name : string.Empty
                };
                model.Add(person);
            }
            return model;
        }

        private Project BuildProject(int projectId)
        {
            var project = _projectService.GetById(projectId);
            return project;
        }

        private IEnumerable<CompanyListingModel> BuildCompanyList()
        {
            var companies = _projectService.GetAllCompanies();
            var model = companies.Select(x => new CompanyListingModel
            {
                Id = x.Id,
                Name = x.Name
            });
            return model;
        }

        private IEnumerable<IssueLogListingModel> BuildIssueLogIndex(IEnumerable<IssueLog> issueLogs, bool isForAll)
        {
            var model = issueLogs.Select(x => new IssueLogListingModel
            {
                Id = x.Id,
                ProjectName = x.Project.Name,
                CompanyName = x.Project.Company.Name,
                IssueDate = x.IssueDate != DateTime.MinValue ? (DateTime?)x.IssueDate : null,
                Header = x.Header,
                IsAllCompletedExceptOwn = x.IssueLogInvolvedPersons.Where(y => y.InvolvedPerson.Id != _userManager.GetUserId(User) && y.IsComplete).ToList().Count == (x.IssueLogInvolvedPersons.Count() - 1),
                IssueInvolvedPersonsName = String.Join(", ",x.IssueLogInvolvedPersons.Select(y => y.InvolvedPerson.UserName)) + ((x.IssueLogInvolvedPersons.Where(y => y.InvolvedPerson.Id != _userManager.GetUserId(User) && y.IsComplete).ToList().Count == (x.IssueLogInvolvedPersons.Count() - 1)) ? " (Please close this issue ASAP.)" : ""),
                EntryById = x.EntryBy.Id,
                CurrentLoginUserId = _userManager.GetUserId(User),
                IsAllInvolvedPersonCompleted = x.IssueLogInvolvedPersons.Where(y => y.IsComplete).ToList().Count == x.IssueLogInvolvedPersons.Count(),
                IsForAll = isForAll
            });
            return model;
        }
    }
}