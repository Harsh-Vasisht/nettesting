using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OM.QSightApi.Inventory.Core.Entities;
using OM.QSightApi.Inventory.Infrastructure.Data;
using OM.QSightApi.Inventory.Infrastructure.Repositories;
using Xunit;

namespace OM.QSightApi.InventoryTests.Infrastructure.Repositories
{
    public class ZeroOutScheduleRepositoryTests
    {
        private readonly InventoryDbContext _dbContext;
        private readonly ZeroOutScheduleRepository _repository;

        public ZeroOutScheduleRepositoryTests()
        {
            // Initialize the database context and repository
            _dbContext = new InventoryDbContext();
            _repository = new ZeroOutScheduleRepository(_dbContext);
        }

        [Fact]
        public async Task GetAllAsync_ReturnsAllZeroOutSchedules()
        {
            // Arrange
            var zeroOutSchedule1 = new ZeroOutSchedule
            {
                Id = 1,
                DepartmentId = 1,
                ScheduledDate = DateTime.Now,
                Status = "Pending"
            };

            var zeroOutSchedule2 = new ZeroOutSchedule
            {
                Id = 2,
                DepartmentId = 2,
                ScheduledDate = DateTime.Now.AddDays(1),
                Status = "Completed"
            };

            _dbContext.ZeroOutSchedules.Add(zeroOutSchedule1);
            _dbContext.ZeroOutSchedules.Add(zeroOutSchedule2);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _repository.GetAllAsync();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.Contains(result, x => x.Id == zeroOutSchedule1.Id);
            Assert.Contains(result, x => x.Id == zeroOutSchedule2.Id);
        }

        [Fact]
        public async Task GetByIdAsync_ReturnsZeroOutSchedule()
        {
            // Arrange
            var zeroOutSchedule = new ZeroOutSchedule
            {
                Id = 1,
                DepartmentId = 1,
                ScheduledDate = DateTime.Now,
                Status = "Pending"
            };

            _dbContext.ZeroOutSchedules.Add(zeroOutSchedule);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _repository.GetByIdAsync(zeroOutSchedule.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(zeroOutSchedule.Id, result.Id);
            Assert.Equal(zeroOutSchedule.DepartmentId, result.DepartmentId);
            Assert.Equal(zeroOutSchedule.ScheduledDate, result.ScheduledDate);
            Assert.Equal(zeroOutSchedule.Status, result.Status);
        }

        [Fact]
        public async Task AddAsync_AddsZeroOutSchedule()
        {
            // Arrange
            var zeroOutSchedule = new ZeroOutSchedule
            {
                Id = 1,
                DepartmentId = 1,
                ScheduledDate = DateTime.Now,
                Status = "Pending"
            };

            // Act
            await _repository.AddAsync(zeroOutSchedule);

            // Assert
            var result = await _dbContext.ZeroOutSchedules.FindAsync(zeroOutSchedule.Id);
            Assert.NotNull(result);
            Assert.Equal(zeroOutSchedule.Id, result.Id);
            Assert.Equal(zeroOutSchedule.DepartmentId, result.DepartmentId);
            Assert.Equal(zeroOutSchedule.ScheduledDate, result.ScheduledDate);
            Assert.Equal(zeroOutSchedule.Status, result.Status);
        }

        [Fact]
        public async Task UpdateAsync_UpdatesZeroOutSchedule()
        {
            // Arrange
            var zeroOutSchedule = new ZeroOutSchedule
            {
                Id = 1,
                DepartmentId = 1,
                ScheduledDate = DateTime.Now,
                Status = "Pending"
            };

            _dbContext.ZeroOutSchedules.Add(zeroOutSchedule);
            await _dbContext.SaveChangesAsync();

            zeroOutSchedule.Status = "Completed";

            // Act
            await _repository.UpdateAsync(zeroOutSchedule);

            // Assert
            var result = await _dbContext.ZeroOutSchedules.FindAsync(zeroOutSchedule.Id);
            Assert.NotNull(result);
            Assert.Equal(zeroOutSchedule.Id, result.Id);
            Assert.Equal(zeroOutSchedule.DepartmentId, result.DepartmentId);
            Assert.Equal(zeroOutSchedule.ScheduledDate, result.ScheduledDate);
            Assert.Equal(zeroOutSchedule.Status, result.Status);
        }

        [Fact]
        public async Task DeleteAsync_DeletesZeroOutSchedule()
        {
            // Arrange
            var zeroOutSchedule = new ZeroOutSchedule
            {
                Id = 1,
                DepartmentId = 1,
                ScheduledDate = DateTime.Now,
                Status = "Pending"
            };

            _dbContext.ZeroOutSchedules.Add(zeroOutSchedule);
            await _dbContext.SaveChangesAsync();

            // Act
            await _repository.DeleteAsync(zeroOutSchedule.Id);

            // Assert
            var result = await _dbContext.ZeroOutSchedules.FindAsync(zeroOutSchedule.Id);
            Assert.Null(result);
        }
    }
}