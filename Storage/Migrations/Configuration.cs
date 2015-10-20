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
                  new Product { Name = "Arla mj�lk", Price = 14, Category = "Mj�lk", Shelf = "H12", Count = 100, Description = "F�rsk mj�lk" },
                  new Product { Name = "Milda", Price = 20, Category = "Sm�r", Shelf = "H12", Count = 89, Description = "F�rskt sm�r" },
                  new Product { Name = "P�gens", Price = 25, Category = "Br�d", Shelf = "H8", Count = 34, Description = "Nybakat br�d" }
                );
            //
        }
    }
}
