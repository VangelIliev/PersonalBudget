using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetServices.ServiceModels
{
    internal class MonthlyExpenseServiceModel
    {
        public Guid Id { get; set; }

        public double TotalAmount { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public string IdentityUserId { get; set; }
    }
}
