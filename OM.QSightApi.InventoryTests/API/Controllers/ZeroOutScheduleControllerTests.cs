using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using OM.QSightApi.Inventory.API.Controllers;
using OM.QSightApi.Inventory.API.Models;
using OM.QSightApi.Inventory.API.Services;
using OM.QSightApi.Inventory.Core.Entities;
using OM.QSightApi.Inventory.Core.Interfaces;
using Xunit;

namespace OM.QSightApi.InventoryTests.API.Controllers
{
    public class ZeroOutScheduleControllerTests
    {
        private readonly ZeroOutScheduleController _controller;
        private readonly Mock<IZeroOutScheduleService> _mockService;

        public ZeroOutScheduleControllerTests()
        {
            _mockService = new Mock<IZeroOutScheduleService>();
            _controller = new ZeroOutScheduleController(_mockService.Object);
        }

        [Fact]
        public async Task GetZeroOutSchedule_ReturnsZeroOutSchedule()
        {
            // Arrange
            var zeroOutSchedule = new ZeroOutSchedule
            {
                Id = 1,
                DepartmentId = 1,
                ScheduledDate = DateTime.Now,
                Status = "Pending"
            };

            _mockService.Setup(x => x.GetZeroOutScheduleAsync(It.IsAny<int>())).ReturnsAsync(zeroOutSchedule);

            // Act
            var result = await _controller.GetZeroOutSchedule(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(zeroOutSchedule.Id, result.Id);
            Assert.Equal(zeroOutSchedule.DepartmentId, result.DepartmentId);
            Assert.Equal(zeroOutSchedule.ScheduledDate, result.ScheduledDate);
            Assert.Equal(zeroOutSchedule.Status, result.Status);
        }

        [Fact]
        public async Task CreateZeroOutSchedule_ReturnsCreatedZeroOutSchedule()
        {
            // Arrange
            var zeroOutScheduleRequest = new ZeroOutScheduleRequest
            {
                DepartmentId = 1,
                ScheduledDate = DateTime.Now,
                Status = "Pending"
            };

            var zeroOutSchedule = new ZeroOutSchedule
            {
                Id = 1,
                DepartmentId = 1,
                ScheduledDate = DateTime.Now,
                Status = "Pending"
            };

            _mockService.Setup(x => x.CreateZeroOutScheduleAsync(It.IsAny<ZeroOutScheduleRequest>())).ReturnsAsync(zeroOutSchedule);

            // Act
            var result = await _controller.CreateZeroOutSchedule(zeroOutScheduleRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(zeroOutSchedule.Id, result.Id);
            Assert.Equal(zeroOutSchedule.DepartmentId, result.DepartmentId);
            Assert.Equal(zeroOutSchedule.ScheduledDate, result.ScheduledDate);
            Assert.Equal(zeroOutSchedule.Status, result.Status);
        }

        [Fact]
        public async Task UpdateZeroOutSchedule_ReturnsUpdatedZeroOutSchedule()
        {
            // Arrange
            var zeroOutScheduleRequest = new ZeroOutScheduleRequest
            {
                DepartmentId = 1,
                ScheduledDate = DateTime.Now,
                Status = "Completed"
            };

            var zeroOutSchedule = new ZeroOutSchedule
            {
                Id = 1,
                DepartmentId = 1,
                ScheduledDate = DateTime.Now,
                Status = "Completed"
            };

            _mockService.Setup(x => x.UpdateZeroOutScheduleAsync(It.IsAny<int>(), It.IsAny<ZeroOutScheduleRequest>())).ReturnsAsync(zeroOutSchedule);

            // Act
            var result = await _controller.UpdateZeroOutSchedule(1, zeroOutScheduleRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(zeroOutSchedule.Id, result.Id);
            Assert.Equal(zeroOutSchedule.DepartmentId, result.DepartmentId);
            Assert.Equal(zeroOutSchedule.ScheduledDate, result.ScheduledDate);
            Assert.Equal(zeroOutSchedule.Status, result.Status);
        }

        [Fact]
        public async Task DeleteZeroOutSchedule_ReturnsNoContent()
        {
            // Arrange
            _mockService.Setup(x => x.DeleteZeroOutScheduleAsync(It.IsAny<int>())).Returns(Task.CompletedTask);

            // Act
            var result = await _controller.DeleteZeroOutSchedule(1);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }
    }
}