using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class TransactionType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}