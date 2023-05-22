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
    public class Client {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Photo { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string PersonalIdentifier { get; set; }
        public string? Location { get; set; }
        [Required]
        public string BarCode { get; set; }
        public string? Notes { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
