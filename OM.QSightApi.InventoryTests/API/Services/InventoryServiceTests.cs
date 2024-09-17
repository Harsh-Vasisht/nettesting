using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using OM.QSightApi.Inventory.API.Services;
using OM.QSightApi.Inventory.Core.Entities;
using OM.QSightApi.Inventory.Core.Interfaces;
using Xunit;

namespace OM.QSightApi.InventoryTests.API.Services
{
    public class InventoryServiceTests
    {
        private readonly Mock<IInventoryRepository> _inventoryRepositoryMock;
        private readonly InventoryService _inventoryService;

        public InventoryServiceTests()
        {
            _inventoryRepositoryMock = new Mock<IInventoryRepository>();
            _inventoryService = new InventoryService(_inventoryRepositoryMock.Object);
        }

        [Fact]
        public void GetProducts_ReturnsListOfProducts()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Description = "Description 1" },
                new Product { Id = 2, Name = "Product 2", Description = "Description 2" }
            };

            _inventoryRepositoryMock.Setup(r => r.GetProducts()).Returns(products);

            // Act
            var result = _inventoryService.GetProducts();

            // Assert
            Assert.Equal(products, result);
        }

        // Add more test methods for other InventoryService methods
    }
}