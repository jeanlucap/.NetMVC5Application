using DesenvolvedorIO.Infra.Data.Context;
using System.Data.Entity.Migrations;
namespace DesenvolvedorIO.Infra.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<MeuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
