using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OM.QSightApi.Inventory.Core.Entities;

namespace OM.QSightApi.InventoryTests.Core.Entities
{
    public class ProductTests
    {
        [Fact]
        public void Product_ShouldHaveValidProperties()
        {
            // Arrange
            var product = new Product
            {
                Id = 1,
                Name = "Test Product",
                Description = "This is a test product",
                UnitOfMeasure = "EA",
                InventoryLevel = 10,
                ReorderLevel = 5,
                ReorderQuantity = 20,
                DepartmentId = 1
            };

            // Act and Assert
            Assert.Equal(1, product.Id);
            Assert.Equal("Test Product", product.Name);
            Assert.Equal("This is a test product", product.Description);
            Assert.Equal("EA", product.UnitOfMeasure);
            Assert.Equal(10, product.InventoryLevel);
            Assert.Equal(5, product.ReorderLevel);
            Assert.Equal(20, product.ReorderQuantity);
            Assert.Equal(1, product.DepartmentId);
        }
    }
}