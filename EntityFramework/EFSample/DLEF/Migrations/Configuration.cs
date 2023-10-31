using System.Data.Entity.Migrations;

namespace DLEF.Migrations {
    internal sealed class Configuration : DbMigrationsConfiguration<DLEF.Context.DLContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DLEF.Context.DLContext context) {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
