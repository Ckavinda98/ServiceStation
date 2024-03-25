using Microsoft.EntityFrameworkCore;

namespace ServiceStation.Web.Models
{
    public class ServiceDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleService> VehicleServices { get; set; }
        public ServiceDbContext(DbContextOptions<ServiceDbContext> options) : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = @"Server=(Localdb)\MSSQLLocaldb;Database=ServiceStationDB;Trusted_Connection=true";
            optionsBuilder.UseSqlServer(connectionstring);
        }
    }
}
