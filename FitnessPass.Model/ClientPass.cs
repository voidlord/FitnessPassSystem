﻿using FitnessPassApp.Data;
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
        public Client Client { get; set; }
        public PassType PassType { get; set; }
        public DateTime CreatedOn { get; set; }
        public int EntryCount { get; set; }
        public int? SalePrice { get; set; }
        public DateTime? FirstUsedOn { get; set; }
        public bool Valid { get; set; }
    }
}
