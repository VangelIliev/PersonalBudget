using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetServices.ServiceModels
{
    internal class MonthlyIncomeServiceModel
    {
        public Guid Id { get; set; }

        public double Amount { get; set; }

        public string IdentityUserId { get; set; }

        public DateTime Date { get; set; }
    }
}
