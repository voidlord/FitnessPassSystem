using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.Model
{
    public class Client {
        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public string Photo { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PersonalIdentifier { get; set; }
        public string Location { get; set; }
        public string BarCode { get; set; }
        public string Notes { get; set; }
    }
}
