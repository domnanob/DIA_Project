using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    [Table("useranswer")]
    public class UserAnswers
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int UserTestID { get; set; }
        
        [Required]
        public int AnswerID { get; set; }

        [Required]
        public int TaskID { get; set; }

#nullable enable
        public string? Answer { get; set; }
    }
}
