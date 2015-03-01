using MonthlyExpenses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RBBudget1.Infrastructure
{
    public class HomeExpensesDb : DbContext, IHomeExpenceDataSource
    {
        public DbSet<HomeMonthlyExpenses> HomeMonthlyExpenses { get; set; }

        IQueryable<HomeMonthlyExpenses> IHomeExpenceDataSource.HomeExpenses
        {
            get { return HomeMonthlyExpenses; }
        }
    }
}