using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Currency
    {
        [Key]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
    }
}