namespace RBBudget1.Migrations
{
    using MonthlyExpenses;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RBBudget1.Infrastructure.HomeExpensesDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RBBudget1.Infrastructure.HomeExpensesDb context)
        {
            context.HomeMonthlyExpenses.AddOrUpdate(
                    e => e.Rent,
                   new HomeMonthlyExpenses
                   {
                       Rent = 800,
                       Electricity = 100,
                       Water = 65
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
