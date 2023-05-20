using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.Model
{
    public class ClientPass {
        [Key]
        public int ClientPassId { get; set; }
        public int ClientId { get; set; }
        public int PassId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string BarCode { get; set; }
        public int EntryCount { get; set; }
        public int SalePrice { get; set; }
        public bool Valid { get; set; }
        public DateTime FirstUsedOn { get; set; }
        public int GymId { get; set; }
    }
}
