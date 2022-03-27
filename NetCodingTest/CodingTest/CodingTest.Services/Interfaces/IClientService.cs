using CodingTest.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Services.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAll();
        Client GetById(int id);
        void Add(Client client);
        Client Update(int id, Client newClient);
        void Delete(int id);
    }
}
