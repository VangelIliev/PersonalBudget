using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalBudgetDb.Entities;

namespace PersonalBudgetDb.DbContext
{
    public class PersonalBudgetDbContext : IdentityDbContext
    {
        public DbSet<DailyExpense> DailyExpenses { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }

        public DbSet<MonthlyExpense> MonthlyExpenses { get; set; }

        public DbSet<MonthlyIncome> MonthlyIncomes { get; set; }

        public DbSet<MonthlyIncomeType> MonthlyIncomeTypes { get; set; }

        public DbSet<YearlyExpense> YearlyExpenses { get; set; }

        public DbSet<YearlyIncome> YearlyIncomes { get; set; }

        public PersonalBudgetDbContext()
        {

        }
        public PersonalBudgetDbContext(DbContextOptions<PersonalBudgetDbContext> options)
            : base(options)
        {

        }
    }
}
