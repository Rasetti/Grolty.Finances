using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Currency
    {
        [Key]
        [MaxLength(3)]
        public string Code { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}