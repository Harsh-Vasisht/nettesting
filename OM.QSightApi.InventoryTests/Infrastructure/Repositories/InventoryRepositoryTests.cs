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
    public class InventoryRepositoryTests
    {
        private readonly InventoryDbContext _dbContext;
        private readonly InventoryRepository _inventoryRepository;

        public InventoryRepositoryTests()
        {
            // Initialize the database context and repository
            _dbContext = new InventoryDbContext();
            _inventoryRepository = new InventoryRepository(_dbContext);
        }

        [Fact]
        public async Task GetAllProducts_ReturnsAllProducts()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Description = "Description 1" },
                new Product { Id = 2, Name = "Product 2", Description = "Description 2" },
                new Product { Id = 3, Name = "Product 3", Description = "Description 3" }
            };

            // Act
            var result = await _inventoryRepository.GetAllProducts();

            // Assert
            Assert.Equal(products.Count, result.Count());
            Assert.Equal(products.Select(p => p.Id), result.Select(p => p.Id));
            Assert.Equal(products.Select(p => p.Name), result.Select(p => p.Name));
            Assert.Equal(products.Select(p => p.Description), result.Select(p => p.Description));
        }

        // Add more test methods for other repository methods
    }
}