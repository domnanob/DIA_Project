using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    [Table("tasks")]
    public class Tasks
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int TestID { get; set; }

        [Required]
        public string Task { get; set; }

        [Required]
        public int Points { get; set; }

        [Required]
        public int TypeID { get; set; }
    }
}
