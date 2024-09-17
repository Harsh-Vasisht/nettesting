using Microsoft.EntityFrameworkCore;
using OM.QSightApi.Inventory.Core.Entities;

namespace OM.QSightApi.Inventory.Infrastructure.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<CycleCount> CycleCounts { get; set; }
        public DbSet<ZeroOutSchedule> ZeroOutSchedules { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}