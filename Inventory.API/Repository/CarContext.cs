using Inventory.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Repository
{
    public class CarDbContext : DbContext
    {
        protected override void OnConfiguring
      (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "InventoryDb");
        }
        public DbSet<Car> Cars { get; set; }

    }
}
