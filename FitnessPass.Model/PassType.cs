using FitnessPass.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int DaysValidFor { get; set; }
        public int? EntriesValidFor { get; set; }
        [Required]
        public Gym Gym { get; set; }
        public int? StartTime { get; set; }
        public int? EndTime { get; set; }
        public int? MaxDailyUse { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
