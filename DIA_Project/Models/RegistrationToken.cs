using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    [Table("registrationtokens")]
    public class RegistrationToken
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Token { get; set; }

        [Required]
        public int ClassID { get; set; }
    }
}
