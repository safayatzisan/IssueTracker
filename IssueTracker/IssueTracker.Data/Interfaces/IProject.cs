﻿using IssueTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Data
{
    public interface IProject
    {
        Project GetById(int id);
        IEnumerable<Project> GetAll();
        void Create(Project Project);
        void Edit(Project Project);
        void Delete(int id);

        Company GetCompanyById(int id);
        IEnumerable<Company> GetAllCompanies();

        ProjectContactPerson GetContactPersonById(int id);
        IEnumerable<ProjectContactPerson> GetAllContactPerson();
    }
}
