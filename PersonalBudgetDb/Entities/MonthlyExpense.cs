using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalBudgetDb.Entities
{
    public class MonthlyExpense
    {
        public MonthlyExpense()
        {
            this.DailyExpenses = new HashSet<DailyExpense>();
        }
        [Key]
        [Required]
        public Guid Id { get; set; }

        public double TotalAmount { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public string IdentityUserId { get; set; }

        [Required]
        public virtual IdentityUser IdentityUser { get; set; }

        public ICollection<DailyExpense> DailyExpenses { get; set; }
    }
}
