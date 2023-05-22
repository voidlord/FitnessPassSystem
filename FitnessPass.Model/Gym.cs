using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.Model
{
    public class Gym {
        [Key]
        public int GymId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
