using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetServices.ServiceModels
{
    internal class ExpenseServiceModel
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public Guid ExpenseCategoryId { get; set; }

        public double Amount { get; set; }
    }
}
