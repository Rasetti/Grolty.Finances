using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{
    public class TransactionType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public TransactionTypes Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}