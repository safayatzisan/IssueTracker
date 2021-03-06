﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IssueTracker.Data;
using IssueTracker.Data.Models;
using IssueTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers
{
    public class DesignationController : Controller
    {
        private readonly IDesignation _designationService;

        public DesignationController(IDesignation designationService)
        {
            _designationService = designationService;
        }

        public IActionResult Index()
        {
            var designations = _designationService.GetAll();
            var model = designations.Select(x => new DesignationListingModel
            {
                Id = x.Id,
                Code = x.Code,
                Name = x.Name
            });
            var indexModel = new DesignationIndexModel
            {
                DesignationList = model
            };
            return View(indexModel);
        }

        public IActionResult Delete(int id)
        {
            _designationService.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View(new DesignationCreateModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DesignationCreateModel model)
        {
            if (ModelState.IsValid)
            {
                var desgination = BuildDesignation(model);
                await _designationService.Create(desgination);
                return RedirectToAction("Index", "Designation");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var designation = _designationService.GetById(id);
            var model = new DesignationListingModel
            {
                Id = designation.Id,
                Code = designation.Code,
                Name = designation.Name
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DesignationListingModel model)
        {
            if (ModelState.IsValid)
            {
                var desgination = BuildDesignation(model);
                await _designationService.Edit(desgination);
                return RedirectToAction("Index", "Designation");
            }
            return View(model);
        }

        private Designation BuildDesignation(DesignationCreateModel model)
        {
            var designation = new Designation
            {
                Code = model.Code,
                Name = model.Name
            };
            return designation;
        }

        private Designation BuildDesignation(DesignationListingModel model)
        {
            var designation = new Designation
            {
                Id = model.Id,
                Code = model.Code,
                Name = model.Name
            };
            return designation;
        }
    }
}