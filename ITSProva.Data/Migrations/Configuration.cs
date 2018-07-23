using System.Data.Entity.Migrations;

namespace ITSProva.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ITSProva.Data.Context.ProvaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ITSProva.Data.Context.ProvaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
