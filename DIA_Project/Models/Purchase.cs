using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIA_Project.Models
{
    [Table("purchases")]
    public class Purchase
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string UserID { get; set; }

        public int JavL { get; set; }

        public int HaziF { get; set; }

        public int KesesI { get; set; }

        public int Jeles { get; set; }
    }
}
