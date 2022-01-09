using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetDb.DbContext
{
    public class PersonalBudgetDbContext : IdentityDbContext
    {
        public PersonalBudgetDbContext()
        {

        }
        public PersonalBudgetDbContext(DbContextOptions<PersonalBudgetDbContext> options)
            : base(options)
        {

        }
    }
}
