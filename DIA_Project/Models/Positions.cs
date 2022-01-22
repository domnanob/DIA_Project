using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    [Table("positions")]
    public class Positions
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string TeacherID { get; set; }

        [Required]
        public int ClassID { get; set; }

        [Required]
        public int SubjectID { get; set; }



    }
}
