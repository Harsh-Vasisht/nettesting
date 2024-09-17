using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OM.QSightApi.Inventory.Core.Entities;
using Xunit;

namespace OM.QSightApi.InventoryTests.Core.Entities
{
    public class ZeroOutScheduleTests
    {
        [Fact]
        public void ZeroOutSchedule_ShouldHaveValidProperties()
        {
            // Arrange
            var zeroOutSchedule = new ZeroOutSchedule
            {
                Id = Guid.NewGuid(),
                DepartmentId = Guid.NewGuid(),
                ScheduledDate = DateTime.UtcNow,
                Status = "Pending",
                CreatedBy = "TestUser",
                CreatedDate = DateTime.UtcNow,
                ModifiedBy = "TestUser",
                ModifiedDate = DateTime.UtcNow
            };

            // Act and Assert
            Assert.NotEqual(Guid.Empty, zeroOutSchedule.Id);
            Assert.NotEqual(Guid.Empty, zeroOutSchedule.DepartmentId);
            Assert.NotNull(zeroOutSchedule.ScheduledDate);
            Assert.Equal("Pending", zeroOutSchedule.Status);
            Assert.Equal("TestUser", zeroOutSchedule.CreatedBy);
            Assert.NotNull(zeroOutSchedule.CreatedDate);
            Assert.Equal("TestUser", zeroOutSchedule.ModifiedBy);
            Assert.NotNull(zeroOutSchedule.ModifiedDate);
        }
    }
}