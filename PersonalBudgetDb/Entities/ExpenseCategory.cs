using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalBudgetDb.Entities
{
    public class ExpenseCategory
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        
        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Description { get; set; }
    }
}
