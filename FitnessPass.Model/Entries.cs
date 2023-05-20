using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.Model
{
    public class Entries {
        [Key]
        public int EntryId { get; set; }
        public int ClientId { get; set; }
        public int PassId { get; set; }
        public int InsertedById { get; set; }
        public DateTime InsertedOn { get; set; }
        public string BarCode { get; set; }
        public int GymId { get; set; }
    }
}
