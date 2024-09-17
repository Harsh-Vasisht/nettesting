using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using OM.QSightApi.Inventory.API.Services;
using OM.QSightApi.Inventory.Core.Entities;
using OM.QSightApi.Inventory.Core.Interfaces;
using OM.QSightApi.Inventory.Infrastructure.Repositories;
using Xunit;

namespace OM.QSightApi.InventoryTests.API.Services
{
    public class ZeroOutScheduleServiceTests
    {
        private readonly Mock<IZeroOutScheduleRepository> _zeroOutScheduleRepositoryMock;
        private readonly ZeroOutScheduleService _zeroOutScheduleService;

        public ZeroOutScheduleServiceTests()
        {
            _zeroOutScheduleRepositoryMock = new Mock<IZeroOutScheduleRepository>();
            _zeroOutScheduleService = new ZeroOutScheduleService(_zeroOutScheduleRepositoryMock.Object);
        }

        [Fact]
        public async Task GetZeroOutSchedule_ReturnsZeroOutSchedule()
        {
            // Arrange
            var expectedZeroOutSchedule = new ZeroOutSchedule
            {
                Id = 1,
                DepartmentId = 1,
                ScheduledDate = DateTime.Now,
                Status = "Pending"
            };

            _zeroOutScheduleRepositoryMock.Setup(r => r.GetZeroOutScheduleAsync(1))
                .ReturnsAsync(expectedZeroOutSchedule);

            // Act
            var actualZeroOutSchedule = await _zeroOutScheduleService.GetZeroOutScheduleAsync(1);

            // Assert
            Assert.Equal(expectedZeroOutSchedule, actualZeroOutSchedule);
        }

        // Add more test cases as needed
    }
}