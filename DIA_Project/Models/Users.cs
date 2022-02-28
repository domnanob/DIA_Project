using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    [Table("users")]
    public class Users
    {
        [Key]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }

        public int Enable { get; set; } = 1;

        public DateTime LastLogon { get; set; } = DateTime.Now;

        public int Money { get; set; } = 0;

        [Required]
        public int ClassID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int RoleID { get; set; } = 3;
    }
}
