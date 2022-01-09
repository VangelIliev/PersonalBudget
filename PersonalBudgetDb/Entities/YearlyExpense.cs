using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalBudgetDb.Entities
{
    public class YearlyExpense
    {
        public YearlyExpense()
        {
            this.MonthlyExpenses = new HashSet<MonthlyExpense>();
        }
        [Key]
        [Required]
        public Guid Id { get; set; }

        public double TotalAmount { get; set; }

        public int Year { get; set; }

        [Required]
        public virtual IdentityUser IdentityUser { get; set; }

        public ICollection<MonthlyExpense> MonthlyExpenses { get; set; }
    }
}
