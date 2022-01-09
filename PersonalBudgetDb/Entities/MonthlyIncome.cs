using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public decimal Amount { get; set; }

        public string IdentityUserId { get; set; }

        public DateTime Date { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
        public ICollection<MonthlyIncomeType> MonthlyIncomeTypes { get; set; }
    }
}
