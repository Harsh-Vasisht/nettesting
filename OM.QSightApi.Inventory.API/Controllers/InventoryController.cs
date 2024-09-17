using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.QSightApi.Inventory.API.Models;
using OM.QSightApi.Inventory.Core.Entities;
using OM.QSightApi.Inventory.Core.Interfaces;

namespace OM.QSightApi.Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetInventory()
        {
            var inventory = await _inventoryService.GetInventoryAsync();
            return Ok(inventory);
        }

        [HttpPost]
        public async Task<IActionResult> CreateInventory(BaseProductRequest request)
        {
            var product = await _inventoryService.CreateProductAsync(request);
            return CreatedAtAction(nameof(GetInventory), product);
        }

        // Add other inventory-related actions here
    }
}