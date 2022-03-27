using CodingTest.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Services.Interfaces
{
    public interface IEmployee
    {
        Task<IEnumerable<Employee>> GetAll();
        Employee GetById(int id);
        void Add(Employee employee);
        Employee Update(int id, Employee newClient);
        void Delete(int id);
    }
}
