using FitnessPass.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Gym Gym { get; set; }
        [ForeignKey("Gym")]
        public int GymFK { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int MaxDailyUse { get; set; }
        public bool IsDeleted { get; set; }
    }
}
