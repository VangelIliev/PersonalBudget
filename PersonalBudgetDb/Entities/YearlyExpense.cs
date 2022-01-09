using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public decimal TotalAmount { get; set; }

        public int Year { get; set; }

        [Required]
        public virtual IdentityUser IdentityUser { get; set; }

        public ICollection<MonthlyExpense> MonthlyExpenses { get; set; }
    }
}
