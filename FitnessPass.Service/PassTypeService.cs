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
        public PassTypeService(AppDbContext appDbContext, GymService gymService)
        {
            this.appDbContext = appDbContext;
            this.gymService = gymService;
        }

        private AppDbContext appDbContext;
        private GymService gymService;

        public List<PassType> GetPassTypes()
        {
            //var passTypes = appDbContext.PassType.ToList();
            //foreach (var passType in passTypes)
            //{
            //    passType.Gym = gymService.GetGymById(passType.GymId);
            //}

            //return passTypes;

            return appDbContext.PassType.ToList();
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

        public void DeletePassTypeById(int id)
        {
            appDbContext.PassType.Find(id).IsDeleted = true;
            appDbContext.SaveChanges();
        }
    }
}
