using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    [Table("teachers")]
    public class Teacher
    {
        [Key]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Enable { get; set; } = 1;

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime LastLogon { get; set; } = DateTime.Now;

    }
}
