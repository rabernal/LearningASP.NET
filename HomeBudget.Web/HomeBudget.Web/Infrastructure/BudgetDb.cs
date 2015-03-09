using HomeBudget.Source;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeBudget.Web.Infrastructure 
{
    public class BudgetDb : DbContext
    {
        public DbSet<Users> UsersD { get; set; }
        public DbSet<Expenses> ExpensesD { get; set; }
    }
}