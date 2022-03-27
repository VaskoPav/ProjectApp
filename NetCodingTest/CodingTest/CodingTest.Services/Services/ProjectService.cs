using CodingTest.DataAccess;
using CodingTest.Models.Models;
using CodingTest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Services.Services
{
    public class ProjectService : IProjectService
    {
        private readonly ProjectDbContext _context;

        public ProjectService(ProjectDbContext context)
        {
            _context = context;
        }
        public void Add(Project employee)
        {
            _context.Project.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            var result = await _context.Project.ToListAsync();
            return result;
        }

        public Project GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Update(int id, Project newProject)
        {
            throw new NotImplementedException();
        }
    }
}
