using FitnessPass.DB;
using FitnessPass.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.Service
{
    public class EntriesService
    {
        private AppDbContext appDbContext;
        private ClientService clientService;
        private PassTypeService passTypeService;

        public EntriesService(AppDbContext appDbContext, ClientService clientService, PassTypeService passTypeService) 
        {
            this.appDbContext = appDbContext;
            this.clientService = clientService;
            this.passTypeService = passTypeService;
        }

        public List<Entries> GetEntries() 
        {
            return appDbContext.Entries.Include(x => x.Client).Include(x => x.PassType).ToList();
        }

        public List<Entries> searchEntriesByClientName(string name) 
        {
            return GetEntries().Where(x => x.Client.Name.Contains(name) && x.Client.IsDeleted == false).ToList();
        }

        public List<Entries> searchEntriesByBarCode(string barCode)
        {
            return GetEntries().Where(x => x.Client.BarCode.Contains(barCode) && x.Client.IsDeleted == false).ToList();
        }

        public List<Entries> searchEntriesByPassType(string passType)
        {
            return GetEntries().Where(x => x.PassType.Name.Contains(passType) && x.PassType.IsDeleted == false).ToList();
        }

        public List<Entries> searchEntriesByInsertedDate(string date)
        {
            return GetEntries().Where(x => areDatesMatching(x.InsertedOn.Date, DateTime.Parse(date)) && x.Client.IsDeleted == false).ToList();
        }

        private bool areDatesMatching(DateTime date1, DateTime date2)
        {
            return date1.Year.Equals(date2.Year) && date1.Month.Equals(date2.Month) && date1.Day.Equals(date2.Day);
        }
    }
}
