using FitnessPass.DB;
using FitnessPass.Model;
using FitnessPassApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.Service
{
    public class PassTypeService
    {
        private AppDbContext appDbContext;

        public PassTypeService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public List<PassType> GetPassTypes()
        {
            return appDbContext.PassType.Include(x => x.Gym).ToList();
        }

        public void AddPassType(PassType passType)
        {
            passType.IsDeleted = false;
            appDbContext.PassType.Add(passType);
            appDbContext.SaveChanges();
        }

        public List<PassType> SearchPassTypeByName(string name)
        {
            return appDbContext.PassType.Where(x => x.Name.Contains(name)).ToList();
        }

        public PassType GetPassTypeById(int id)
        {
            return appDbContext.PassType.Find(id) ?? new PassType();
        }

        public void UpdatePassType(PassType passType)
        {
            appDbContext.PassType.Update(passType);
            appDbContext.SaveChanges();
        }

        public void ChangePassTypeStatusById(int id)
        { 
            appDbContext.PassType.Find(id).IsDeleted = !appDbContext.PassType.Find(id).IsDeleted;
            appDbContext.SaveChanges();
        }
    }
}
