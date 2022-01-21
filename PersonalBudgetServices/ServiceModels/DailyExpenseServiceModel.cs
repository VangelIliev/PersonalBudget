using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetServices.ServiceModels
{
    internal class DailyExpenseServiceModel
    {
        public Guid Id { get; set; }

        public double TotalAmount { get; set; }

        public DateTime Date { get; set; }

        public string IdentityUserId { get; set; }

    }
}
