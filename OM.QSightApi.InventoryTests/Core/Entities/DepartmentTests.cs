using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OM.QSightApi.Inventory.Core.Entities;

namespace OM.QSightApi.InventoryTests.Core.Entities
{
    public class DepartmentTests
    {
        [Fact]
        public void Department_CanBeCreated()
        {
            // Arrange
            var department = new Department
            {
                Id = 1,
                Name = "Test Department",
                LocationId = 1
            };

            // Assert
            Assert.NotNull(department);
            Assert.Equal(1, department.Id);
            Assert.Equal("Test Department", department.Name);
            Assert.Equal(1, department.LocationId);
        }
    }
}