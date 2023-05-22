using FitnessPass.DB;
using FitnessPass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.Service {
    public class UserService {
        private AppDbContext appDbContext;

        public UserService(AppDbContext appDbContext) {
            this.appDbContext = appDbContext;
        }

        public User Login(string email, string password) {
            return appDbContext.User.Where(x => x.Email == email && x.Password == password).ToList().First();
        }
    }
}
