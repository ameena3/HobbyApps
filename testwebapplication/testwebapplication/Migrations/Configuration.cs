namespace testwebapplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<testwebapplication.Models.mynewonlineretaurant>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(testwebapplication.Models.mynewonlineretaurant context)
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

            for (int i = 0; i < 1000; i++)
            {

                context.Restaurants.AddOrUpdate(
                  p => p.name,
                  new Models.Restaurant { name = i.ToString(), City = "Nowhere", Country = "USA" }
            );
        }



        }
    }
}
