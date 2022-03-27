using CodingTest.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Services.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAll();
        Project GetById(int id);
        void Add(Project employee);
        Employee Update(int id, Project newProject);
        void Delete(int id);
    }
}
