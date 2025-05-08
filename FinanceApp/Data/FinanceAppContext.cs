using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data
{
    public class FinanceAppContext :Microsoft.EntityFrameworkCore.DbContext 
    {

        //constuctor
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options): base(options) { }

        //public - accessible even outside this class
        public DbSet<Models.Expense> Expenses { get; set; }



    }
}
