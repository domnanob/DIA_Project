using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    [Table("subjects")]
    public class Subjects
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
