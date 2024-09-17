using OM.QSightApi.Inventory.Core.Entities;
using OM.QSightApi.Inventory.Core.Interfaces;
using OM.QSightApi.Inventory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OM.QSightApi.Inventory.Infrastructure.Repositories
{
    public class ZeroOutScheduleRepository : IZeroOutScheduleService
    {
        private readonly InventoryDbContext _dbContext;

        public ZeroOutScheduleRepository(InventoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ZeroOutSchedule> GetZeroOutScheduleByIdAsync(int id)
        {
            return await _dbContext.ZeroOutSchedules.FindAsync(id);
        }

        public async Task<IEnumerable<ZeroOutSchedule>> GetAllZeroOutSchedulesAsync()
        {
            return await _dbContext.ZeroOutSchedules.ToListAsync();
        }

        public async Task CreateZeroOutScheduleAsync(ZeroOutSchedule zeroOutSchedule)
        {
            await _dbContext.ZeroOutSchedules.AddAsync(zeroOutSchedule);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateZeroOutScheduleAsync(ZeroOutSchedule zeroOutSchedule)
        {
            _dbContext.ZeroOutSchedules.Update(zeroOutSchedule);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteZeroOutScheduleAsync(int id)
        {
            var zeroOutSchedule = await _dbContext.ZeroOutSchedules.FindAsync(id);
            _dbContext.ZeroOutSchedules.Remove(zeroOutSchedule);
            await _dbContext.SaveChangesAsync();
        }
    }
}