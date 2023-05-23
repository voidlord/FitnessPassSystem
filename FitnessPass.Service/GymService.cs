using FitnessPass.DB;
using FitnessPass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.Service
{
    public class GymService
    {
        private AppDbContext appDbContext;

        public GymService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Gym GetGymById(int id)
        {
            //var query = from st in appDbContext.Gym
            //            where st.GymId == id
            //            select st;
            //return query.First();
            return appDbContext.Gym.Find(id) ?? new Gym();
        }

        public Gym GetGymByName(string name)
        {
            return appDbContext.Gym.Where(x => x.Name == name).First();
        }
    }
}