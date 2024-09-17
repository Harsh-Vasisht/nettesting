using OM.QSightApi.Inventory.Core.Entities;
using OM.QSightApi.Inventory.Core.Interfaces;
using OM.QSightApi.Inventory.Infrastructure.Repositories;

namespace OM.QSightApi.Inventory.API.Services
{
    public class ZeroOutScheduleService : IZeroOutScheduleService
    {
        private readonly ZeroOutScheduleRepository _zeroOutScheduleRepository;

        public ZeroOutScheduleService(ZeroOutScheduleRepository zeroOutScheduleRepository)
        {
            _zeroOutScheduleRepository = zeroOutScheduleRepository;
        }

        public async Task<ZeroOutSchedule> GetZeroOutScheduleAsync(int id)
        {
            return await _zeroOutScheduleRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<ZeroOutSchedule>> GetAllZeroOutSchedulesAsync()
        {
            return await _zeroOutScheduleRepository.GetAllAsync();
        }

        public async Task CreateZeroOutScheduleAsync(ZeroOutSchedule zeroOutSchedule)
        {
            await _zeroOutScheduleRepository.AddAsync(zeroOutSchedule);
        }

        public async Task UpdateZeroOutScheduleAsync(ZeroOutSchedule zeroOutSchedule)
        {
            await _zeroOutScheduleRepository.UpdateAsync(zeroOutSchedule);
        }

        public async Task DeleteZeroOutScheduleAsync(int id)
        {
            await _zeroOutScheduleRepository.DeleteAsync(id);
        }
    }
}