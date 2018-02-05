namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Warehouse.Models.WarehouseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Warehouse.Models.WarehouseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(    //-people-tabell
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate( //- lägg till eller uppdatera om 
                p => p.Name,
                new Models.Product { Name = "Waffler",         Category = "appliances",  Price = 578,  Count = 30 },
                new Models.Product { Name = "Somsang GX-1000", Category = "electronics", Price = 2099, Count = 3  },
                new Models.Product { Name = "Strykjärn",       Category = "appliances",  Price = 199,  Count = 30 },
                new Models.Product { Name = "Dammsugare", Category = "appliances", Price = 5000, Count = 6,
                    Description = "En tjusig dammsugare." },
                new Models.Product { Name = "Toaster", Category = "appliances", Price = 300, Count = 45,
                Description = "En fin fin brödrost."}
                );


        }
    }
}
