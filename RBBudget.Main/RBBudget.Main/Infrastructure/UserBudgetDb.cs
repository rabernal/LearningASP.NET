using RBBudget.DataSource;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RBBudget.Main.Infrastructure
{
    public class UserBudgetDb : DbContext, IUsersBudgetData
    {
        //public UserBudgetDb() : base("name=DefaultConnection")
        //{

        //}
        public DbSet<UserBudget> UsersBudget { get; set; }


        IQueryable<UserBudget> IUsersBudgetData.UsersBudget
        {
            get
            {
                return UsersBudget;
            }
        }
    }
}