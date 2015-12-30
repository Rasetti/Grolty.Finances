using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class AccountSource
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}