using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIA_Project.Models
{
    [Table("subjects")]
    public class Subject
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
