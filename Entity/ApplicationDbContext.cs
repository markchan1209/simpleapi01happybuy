using Microsoft.EntityFrameworkCore;
using SimpleWebApi.Entity;

namespace SimpleWebApi2.Entity
{
    public class ApplicationDbContext : DbContext
    {
       protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
    }
}