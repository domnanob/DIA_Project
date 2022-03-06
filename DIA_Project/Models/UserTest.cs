using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Models
{
    [Table("usertests")]
    public class UserTest
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public string UserID { get; set; }

        [Required]
        public int TestID { get; set; }

        [Required]
        public int Completed { get; set; } = 0;

        [Required]
        public double Points { get; set; }

        [Required]
        public int CorrectState { get; set; } = 0;

        public DateTime? FinishDate { get; set; }


    }
}
