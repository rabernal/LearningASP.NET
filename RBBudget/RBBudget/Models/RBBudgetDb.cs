using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RBBudget.Models
{
    public class RBBudgetDb : DbContext
    {
        public RBBudgetDb() : base("name=DefaultConnection")
        {
             
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Utility> Utilities { get; set; }
    }
}