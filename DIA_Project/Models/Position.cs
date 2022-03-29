using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIA_Project.Models
{
    [Table("positions")]
    public class Position
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
