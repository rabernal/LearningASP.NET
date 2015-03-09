namespace HomeBudget.Web.Migrations
{
    using HomeBudget.Source;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeBudget.Web.Infrastructure.BudgetDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HomeBudget.Web.Infrastructure.BudgetDb context)
        {
            context.UsersD.AddOrUpdate(u => u.Fname, 
                new Users
                {
                    Fname = "Rafael",
                    Lname = "Bernal",
                });
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
