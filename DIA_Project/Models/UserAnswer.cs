using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIA_Project.Models
{
    [Table("useranswer")]
    public class UserAnswer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int UserTestID { get; set; }

        [Required]
        public int AnswerID { get; set; }

        [Required]
        public int TaskID { get; set; }

    }
}
