using System.Data.Entity.Migrations;

namespace ITS.Prova.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ITS.Prova.Data.Context.ProvaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ITS.Prova.Data.Context.ProvaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
