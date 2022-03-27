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
    public class EmployeeService : IEmployee
    {
        private readonly ProjectDbContext _context;
        public EmployeeService(ProjectDbContext context)
        {
            _context = context;
        }
        public void Add(Employee employee)
        {
            _context.Employee.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            var result = await _context.Employee.ToListAsync();
            return result;
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Update(int id, Employee newClient)
        {
            throw new NotImplementedException();
        }
    }
}
