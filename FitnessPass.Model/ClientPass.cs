using FitnessPassApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.Model
{
    public class ClientPass {
        [Key]
        public int ClientPassId { get; set; }
        [Required]
        public Client Client { get; set; }
        [Required]
        public PassType PassType { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public int EntryCount { get; set; }
        public int? SalePrice { get; set; }
        public DateTime? FirstUsedOn { get; set; }
        [Required]
        public bool Valid { get; set; }
    }
}
