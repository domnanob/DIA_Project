using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    [Table("purchases")]
    public class Purchases
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string UserID { get; set; }

        [Required]
        public int JavL { get; set; }

        [Required]
        public int HaziF { get; set; }

        [Required]
        public int KesesI { get; set; }

        [Required]
        public int Jeles { get; set; }
    }
}
