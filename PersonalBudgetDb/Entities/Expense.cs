using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetDb.Entities
{
    public class Expense
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public Guid ExpenseCategoryId { get; set; }

        public virtual ExpenseCategory ExpenseCategory { get; set; }

        public decimal Amount { get; set; }

        [Required]
        public string IdentityUserId { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }
    }
}
