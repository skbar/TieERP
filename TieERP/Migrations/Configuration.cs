namespace TieERP.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TieERP.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TieERP.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TieERP.Models.ApplicationDbContext context)
        {
            context.Warehouses.AddOrUpdate(c => c.Name, new Warehouse { Name = "Magazyn1" }, new Warehouse { Name = "Magazyn2" });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
