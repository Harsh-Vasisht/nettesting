using OM.QSightApi.Inventory.Core.Entities;
using OM.QSightApi.Inventory.Core.Interfaces;
using OM.QSightApi.Inventory.Infrastructure.Data;
using OM.QSightApi.Inventory.Infrastructure.Repositories;

namespace OM.QSightApi.Inventory.API.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly InventoryDbContext _dbContext;
        private readonly InventoryRepository _inventoryRepository;

        public InventoryService(InventoryDbContext dbContext, InventoryRepository inventoryRepository)
        {
            _dbContext = dbContext;
            _inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _inventoryRepository.GetProducts();
        }

        public async Task<IEnumerable<CycleCount>> GetCycleCounts()
        {
            return await _inventoryRepository.GetCycleCounts();
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _inventoryRepository.GetDepartments();
        }

        public async Task<ZeroOutSchedule> GetZeroOutSchedule(int id)
        {
            return await _inventoryRepository.GetZeroOutSchedule(id);
        }

        public async Task CreateProduct(Product product)
        {
            await _inventoryRepository.CreateProduct(product);
        }

        public async Task CreateCycleCount(CycleCount cycleCount)
        {
            await _inventoryRepository.CreateCycleCount(cycleCount);
        }

        public async Task CreateDepartment(Department department)
        {
            await _inventoryRepository.CreateDepartment(department);
        }

        public async Task CreateZeroOutSchedule(ZeroOutSchedule zeroOutSchedule)
        {
            await _inventoryRepository.CreateZeroOutSchedule(zeroOutSchedule);
        }

        public async Task UpdateProduct(Product product)
        {
            await _inventoryRepository.UpdateProduct(product);
        }

        public async Task UpdateCycleCount(CycleCount cycleCount)
        {
            await _inventoryRepository.UpdateCycleCount(cycleCount);
        }

        public async Task UpdateDepartment(Department department)
        {
            await _inventoryRepository.UpdateDepartment(department);
        }

        public async Task UpdateZeroOutSchedule(ZeroOutSchedule zeroOutSchedule)
        {
            await _inventoryRepository.UpdateZeroOutSchedule(zeroOutSchedule);
        }

        public async Task DeleteProduct(int id)
        {
            await _inventoryRepository.DeleteProduct(id);
        }

        public async Task DeleteCycleCount(int id)
        {
            await _inventoryRepository.DeleteCycleCount(id);
        }

        public async Task DeleteDepartment(int id)
        {
            await _inventoryRepository.DeleteDepartment(id);
        }

        public async Task DeleteZeroOutSchedule(int id)
        {
            await _inventoryRepository.DeleteZeroOutSchedule(id);
        }
    }
}