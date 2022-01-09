using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PersonalBudgetDb.Entities
{
    public class DailyExpense
    {
        public DailyExpense()
        {
            this.Expenses = new HashSet<Expense>();
        }
        [Key]
        [Required]
        public Guid Id { get; set; }

        public double TotalAmount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string IdentityUserId { get; set; }

        [Required]
        public virtual IdentityUser IdentityUser { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
