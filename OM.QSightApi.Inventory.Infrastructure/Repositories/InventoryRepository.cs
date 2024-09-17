using OM.QSightApi.Inventory.Core.Entities;
using OM.QSightApi.Inventory.Core.Interfaces;
using OM.QSightApi.Inventory.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OM.QSightApi.Inventory.Infrastructure.Repositories
{
    public class InventoryRepository : IInventoryService
    {
        private readonly InventoryDbContext _dbContext;

        public InventoryRepository(InventoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<IEnumerable<CycleCount>> GetCycleCounts()
        {
            return await _dbContext.CycleCounts.ToListAsync();
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _dbContext.Departments.ToListAsync();
        }

        public async Task<IEnumerable<ZeroOutSchedule>> GetZeroOutSchedules()
        {
            return await _dbContext.ZeroOutSchedules.ToListAsync();
        }

        // Add other repository methods as needed
    }
}