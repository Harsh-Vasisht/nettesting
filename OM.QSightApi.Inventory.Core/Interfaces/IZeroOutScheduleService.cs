using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OM.QSightApi.Inventory.Core.Entities;

namespace OM.QSightApi.Inventory.Core.Interfaces
{
    public interface IZeroOutScheduleService
    {
        Task<IEnumerable<ZeroOutSchedule>> GetAllZeroOutSchedulesAsync();
        Task<ZeroOutSchedule> GetZeroOutScheduleByIdAsync(Guid id);
        Task<ZeroOutSchedule> CreateZeroOutScheduleAsync(ZeroOutSchedule zeroOutSchedule);
        Task<ZeroOutSchedule> UpdateZeroOutScheduleAsync(ZeroOutSchedule zeroOutSchedule);
        Task DeleteZeroOutScheduleAsync(Guid id);
    }
}