using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public decimal Amount { get; set; }

        public string IdentityUserId { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
    }
}
