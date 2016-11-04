using System.Data.Entity.Migrations;

namespace ThumanSon.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ThumanSon.EntityFramework.ThumanSonDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ThumanSon";
        }

        protected override void Seed(ThumanSon.EntityFramework.ThumanSonDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
