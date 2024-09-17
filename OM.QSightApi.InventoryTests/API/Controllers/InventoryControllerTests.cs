using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OM.QSightApi.Inventory.API.Controllers;
using OM.QSightApi.Inventory.API.Models;
using OM.QSightApi.Inventory.API.Services;
using Moq;

namespace OM.QSightApi.InventoryTests.API.Controllers
{
    public class InventoryControllerTests
    {
        private readonly InventoryController _controller;
        private readonly Mock<IInventoryService> _inventoryServiceMock;

        public InventoryControllerTests()
        {
            _inventoryServiceMock = new Mock<IInventoryService>();
            _controller = new InventoryController(_inventoryServiceMock.Object);
        }

        [Fact]
        public async Task GetCycleCountItems_ReturnsExpectedResult()
        {
            // Arrange
            var cycleCountItemInfo = new CycleCountItemInfo
            {
                ProductId = 1,
                ProductName = "Product 1",
                Quantity = 10,
                DiscrepancyType = DiscrepancyTypes.None
            };

            _inventoryServiceMock.Setup(x => x.GetCycleCountItems()).ReturnsAsync(new List<CycleCountItemInfo> { cycleCountItemInfo });

            // Act
            var result = await _controller.GetCycleCountItems();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal(cycleCountItemInfo.ProductId, result.First().ProductId);
            Assert.Equal(cycleCountItemInfo.ProductName, result.First().ProductName);
            Assert.Equal(cycleCountItemInfo.Quantity, result.First().Quantity);
            Assert.Equal(cycleCountItemInfo.DiscrepancyType, result.First().DiscrepancyType);
        }
    }
}