namespace TESTBoilerplate.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TESTBoilerplate.EntityFramework.TESTBoilerplateDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TESTBoilerplate";
        }

        protected override void Seed(TESTBoilerplate.EntityFramework.TESTBoilerplateDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
