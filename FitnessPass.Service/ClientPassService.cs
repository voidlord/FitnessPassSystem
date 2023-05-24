using FitnessPass.DB;
using FitnessPass.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.Service {
    public class ClientPassService {
        private AppDbContext appDbContext;

        public ClientPassService(AppDbContext appDbContext) {
            this.appDbContext = appDbContext;
        }

        public List<ClientPass> GetPassesByClientId(int clientId) {
            return appDbContext.ClientPass.Where(x => x.ClientId == clientId).Include(x => x.PassType).ToList();
        }
    }
}
