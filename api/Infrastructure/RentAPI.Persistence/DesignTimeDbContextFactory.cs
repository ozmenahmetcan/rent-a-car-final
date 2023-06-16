using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RentAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RentAPIDbContext>
    {

        public RentAPIDbContext CreateDbContext(string[] args)
        {

            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/RentAPI.API"));
            configurationManager.AddJsonFile("appsettings.json");

            DbContextOptionsBuilder<RentAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
