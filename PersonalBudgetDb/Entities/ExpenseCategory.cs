using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetDb.Entities
{
    public class ExpenseCategory
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        
        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Description { get; set; }
    }
}
