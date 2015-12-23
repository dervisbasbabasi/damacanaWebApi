namespace WebApplication5.Migrations9
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication5.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication5.Models.WebApplication5Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WebApplication5.Models.WebApplication5Context context)
        {
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

            context.Products.AddOrUpdate(p => p.Id,
            new Product() { Id = 1, Name = "Erikli", Price = 10 },
            new Product() { Id = 2, Name = "Pinar", Price = 8 },
            new Product() { Id = 3, Name = "Saka", Price = 9 }
            );
        }
    }
}
