namespace Storage.Migrations
{
    using Storage.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Storage.DataAccessLayer.StorageContent>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Storage.DataAccessLayer.StorageContent context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Products.AddOrUpdate(
                  p => p.Name,
                  new Product { Name = "Arla mjölk", Price = 14, Category = "Mjölk", Shelf = "H12", Count = 100, Description = "Färsk mjölk" },
                  new Product { Name = "Milda", Price = 20, Category = "Smör", Shelf = "H12", Count = 89, Description = "Färskt smör" },
                  new Product { Name = "Pågens", Price = 25, Category = "Bröd", Shelf = "H8", Count = 34, Description = "Nybakat bröd" }
                );
            //
        }
    }
}
