using Microsoft.EntityFrameworkCore;
using MyMinimalApi.Models;

namespace MyMinimalApi.Data
{
    public class MyMinimalApiContext : DbContext
    {
        public MyMinimalApiContext(DbContextOptions<MyMinimalApiContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle
            {
                Name = "Toyota Corolla",
                Model = "Corolla Cross",
                StartProduction = DateTime.UtcNow,
                FuelType = "Petrol(Gasoline)"
            });
        }

        public DbSet<Vehicle> Vehicles => Set<Vehicle>();

    }
}
