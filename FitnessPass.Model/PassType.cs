using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPassApp.Data
{
    public class PassType
    {
        [Key]
        public int PassId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int DaysValidFor { get; set; }
        public int EntriesValidFor { get; set; }
        public bool IsDeleted { get; set; }
        public int GymId { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int MaxDailyUse { get; set; }
    }
}
