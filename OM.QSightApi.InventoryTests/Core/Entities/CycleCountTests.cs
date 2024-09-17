using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OM.QSightApi.Inventory.Core.Entities;
using Xunit;

namespace OM.QSightApi.InventoryTests.Core.Entities
{
    public class CycleCountTests
    {
        [Fact]
        public void CycleCount_Constructor_ShouldInitializeProperties()
        {
            // Arrange
            Guid id = Guid.NewGuid();
            Guid departmentId = Guid.NewGuid();
            Guid productId = Guid.NewGuid();
            int quantity = 10;
            DateTime countDate = DateTime.Now;
            string countBy = "John Doe";
            string notes = "Test notes";

            // Act
            var cycleCount = new CycleCount(id, departmentId, productId, quantity, countDate, countBy, notes);

            // Assert
            Assert.Equal(id, cycleCount.Id);
            Assert.Equal(departmentId, cycleCount.DepartmentId);
            Assert.Equal(productId, cycleCount.ProductId);
            Assert.Equal(quantity, cycleCount.Quantity);
            Assert.Equal(countDate, cycleCount.CountDate);
            Assert.Equal(countBy, cycleCount.CountBy);
            Assert.Equal(notes, cycleCount.Notes);
        }
    }
}