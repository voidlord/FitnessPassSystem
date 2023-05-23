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
        public Client Client { get; set; }
        [ForeignKey("Client")]
        public int ClientFK { get; set; }
        public PassType PassType { get; set; }
        [ForeignKey("PassType")]
        public int PassTypeFK { get; set; }
        public int InsertedById { get; set; }
        public DateTime InsertedOn { get; set; }
    }
}
