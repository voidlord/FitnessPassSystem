using FitnessPass.DB;
using FitnessPass.Model;
using FitnessPassApp.Data;
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
            return appDbContext.User.Where(x => x.Email == email && x.Password == password).ToList().FirstOrDefault();
        }

        public List<User> GetUsers() 
        {
            return appDbContext.User.Where(x => x.IsDeleted == false).ToList();
        }

        public void AddUser(User user)
        {
            user.CreatedOn = DateTime.Now;
            user.IsDeleted = false;
            appDbContext.User.Add(user);
            appDbContext.SaveChanges();
        }

        public List<User> SearchUserByName(string name)
        {
            return appDbContext.User.Where(x => x.Name.Contains(name) && x.IsDeleted == false).ToList();
        }

        public User GetUserById(int id)
        {
            return appDbContext.User.Find(id) ?? new User();
        }

        public void UpdateUser(User user) 
        {
            appDbContext.User.Update(user);
            appDbContext.SaveChanges();
        }

        public void DeleteUserById(int id)
        {
            appDbContext.User.Find(id).IsDeleted = true;
            appDbContext.SaveChanges();
        }
    }
}
