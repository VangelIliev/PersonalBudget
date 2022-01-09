using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetDb.Entities
{
    public class YearlyIncome
    {
        public YearlyIncome()
        {
            this.MonthlyIncomes = new HashSet<MonthlyIncome>();
        }
        [Key]
        [Required]
        public Guid Id { get; set; }

        public int Year { get; set; }

        public decimal Amount { get; set; }

        public string IdentityUserId  { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }

        public virtual ICollection<MonthlyIncome> MonthlyIncomes { get; set; }
    }
}
