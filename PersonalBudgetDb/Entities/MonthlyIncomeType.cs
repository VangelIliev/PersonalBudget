using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalBudgetDb.Entities
{
    public class MonthlyIncomeType
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [MinLength(4)]
        [MaxLength(30)]
        public string Description { get; set; }

        public double Amount { get; set; }

        public string IdentityUserId { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
    }
}
