using FitnessPass.DB;
using FitnessPass.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.Service
{
    public class ClientService
    {
        public ClientService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        private AppDbContext appDbContext;

        public Task AddClient(Client client)
        {
            client.IsDeleted = false;
            client.CreatedDate = DateTime.Now;
            appDbContext.Client.Add(client);
            appDbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public List<Client> GetClients()
        {
            return appDbContext.Client.Where(x => x.IsDeleted == false).ToList();
        }

        public List<Client> SearchClientByName(string name) 
        {
            return appDbContext.Client.Where(x => x.Name.Contains(name) && x.IsDeleted == false).ToList();
        }

        public Client GetClientById(int id)
        {
            return appDbContext.Client.Find(id) ?? new Client();
        }

        public void UpdateClient(Client client) 
        {
            appDbContext.Client.Update(client);
            appDbContext.SaveChanges();
        }

        public void DeleteClientById(int id) 
        {
            appDbContext.Client.Find(id).IsDeleted = true;
            appDbContext.SaveChanges();
        }

        public List<string> GetEmails() {
            return appDbContext.Client.Select(x => x.Email).Where(x => !String.IsNullOrWhiteSpace(x)).ToList();
        }
    }
}
