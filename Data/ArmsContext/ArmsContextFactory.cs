using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ArmsContext
{
    public class ArmsContextFactory : IDesignTimeDbContextFactory<ArmsDbContext>
    {
        public ArmsDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ArmsConnectionString");
            var optionBuilder = new DbContextOptionsBuilder<ArmsDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new ArmsDbContext(optionBuilder.Options);
        }
    }
}
