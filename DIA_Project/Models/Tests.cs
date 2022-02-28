using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    [Table("tests")]
    public class Tests
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string TeacherID { get; set; }

        [Required]
        public int SubjectID { get; set; }

        [Required]
        public int ClassID { get; set; }

        [Required]
        public int MaxPoints { get; set; }

        [Required]
        public int Locked { get; set; } = 0;

        [Required]
        public DateTime FinishDate { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public int InternetAllowed { get; set; }

    }
}
