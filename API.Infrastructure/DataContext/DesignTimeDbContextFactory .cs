using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace API.Insfratructure.DataContext
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EShopContext>
    {
        public EShopContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EShopContext>();
            var connectionString = "Server=DESKTOP-TCV6EUK;Database=EShopper;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
            builder.UseSqlServer(connectionString);
            return new EShopContext(builder.Options);
        }
    }
}
