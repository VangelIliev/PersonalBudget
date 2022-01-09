using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalBudgetDb.Entities
{
    public class MonthlyIncome
    {
        public MonthlyIncome()
        {
            this.MonthlyIncomeTypes = new HashSet<MonthlyIncomeType>(); 
        }
        [Key]
        [Required]
        public Guid Id { get; set; }

        public double Amount { get; set; }

        public string IdentityUserId { get; set; }

        public DateTime Date { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
        public ICollection<MonthlyIncomeType> MonthlyIncomeTypes { get; set; }
    }
}
