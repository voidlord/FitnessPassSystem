using FitnessPassApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.Model
{
    public class Entries {
        [Key]
        public int EntryId { get; set; }
        [Required]
        public Client Client { get; set; }
        [Required]
        public PassType PassType { get; set; }
        [Required]
        public int InsertedById { get; set; }
        [Required]
        public DateTime InsertedOn { get; set; }
    }
}
