namespace RBBudget.Migrations
{
    using RBBudget.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RBBudget.Models.RBBudgetDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RBBudget.Models.RBBudgetDb context)
        {
            context.Users.AddOrUpdate(
                    u => u.Fname,
                    new User {
                        Fname = "Rafael",
                        Lname = "Bernal",
                        Salary = 58000,
                        },
                    new User {
                        Fname = "Raquel",
                        Lname = "Bernal",
                        Salary = 45000,
                    },
                    new User
                    {
                        Fname = "Yahir",
                        Lname = "Bernal",
                        Salary = 10000,
                        UtilityCollection = new List<Utility> {
                            new Utility {RentAmount = 25}
                        }
                    }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
