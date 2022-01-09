using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public decimal TotalAmount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string IdentityUserId { get; set; }

        [Required]
        public virtual IdentityUser IdentityUser { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
