using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OM.QSightApi.Inventory.Core.Entities;

namespace OM.QSightApi.Inventory.Core.Interfaces
{
    public interface IInventoryService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<IEnumerable<CycleCount>> GetAllCycleCounts();
        Task<CycleCount> GetCycleCountById(int id);
        Task<IEnumerable<Department>> GetAllDepartments();
        Task<Department> GetDepartmentById(int id);
        Task<IEnumerable<ZeroOutSchedule>> GetAllZeroOutSchedules();
        Task<ZeroOutSchedule> GetZeroOutScheduleById(int id);
    }
}