using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Imobiliaria.DataBase
{
    public class ImobiliariaContextFactory : IDesignTimeDbContextFactory<ImobiliariaContext>
    {
        public ImobiliariaContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ImobiliariaContext>();
            var connectionString = configuration.GetConnectionString("ApresentacaoDb");
            builder.UseSqlServer(connectionString);

            return new ImobiliariaContext(builder.Options);
        }
    }
}
