using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public decimal TotalAmount { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public string IdentityUserId { get; set; }

        [Required]
        public virtual IdentityUser IdentityUser { get; set; }

        public ICollection<DailyExpense> DailyExpenses { get; set; }
    }
}
