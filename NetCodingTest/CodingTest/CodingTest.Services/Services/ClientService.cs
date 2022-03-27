using CodingTest.DataAccess;
using CodingTest.Models.Models;
using CodingTest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Services.Services
{
    public class ClientService : IClientService
    {
        private readonly ProjectDbContext _context;

        public ClientService(ProjectDbContext context)
        {
            _context = context;
        }
        public void Add(Client client)
        {
            _context.Client.Add(client);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            var result =await _context.Client.ToListAsync();
            return result;
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Client Update(int id, Client newClient)
        {
            throw new NotImplementedException();
        }

        
    }
}
