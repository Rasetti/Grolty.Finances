using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Amount { get; set; }
      
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public Period Period { get; set; }

        [Required]
        public TransactionType TransactionType { get; set; }

        public Currency Currency { get; set; }
    }
}