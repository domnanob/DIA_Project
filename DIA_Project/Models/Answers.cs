using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIA_Project.Models
{
    [Table("answers")]
    public class Answers
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int TaskID { get; set; }

        [Required]
        public string Answer { get; set; }

        [Required]
        public int Correct { get; set; }
    }
}
