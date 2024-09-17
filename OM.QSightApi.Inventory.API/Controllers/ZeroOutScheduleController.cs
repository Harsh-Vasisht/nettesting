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
    public class ZeroOutScheduleController : ControllerBase
    {
        private readonly IZeroOutScheduleService _zeroOutScheduleService;

        public ZeroOutScheduleController(IZeroOutScheduleService zeroOutScheduleService)
        {
            _zeroOutScheduleService = zeroOutScheduleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetZeroOutSchedules()
        {
            var zeroOutSchedules = await _zeroOutScheduleService.GetZeroOutSchedulesAsync();
            return Ok(zeroOutSchedules);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetZeroOutScheduleById(int id)
        {
            var zeroOutSchedule = await _zeroOutScheduleService.GetZeroOutScheduleByIdAsync(id);
            if (zeroOutSchedule == null)
            {
                return NotFound();
            }
            return Ok(zeroOutSchedule);
        }

        [HttpPost]
        public async Task<IActionResult> CreateZeroOutSchedule(ZeroOutSchedule zeroOutSchedule)
        {
            var createdZeroOutSchedule = await _zeroOutScheduleService.CreateZeroOutScheduleAsync(zeroOutSchedule);
            return CreatedAtAction(nameof(GetZeroOutScheduleById), new { id = createdZeroOutSchedule.Id }, createdZeroOutSchedule);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateZeroOutSchedule(int id, ZeroOutSchedule zeroOutSchedule)
        {
            if (id != zeroOutSchedule.Id)
            {
                return BadRequest();
            }

            await _zeroOutScheduleService.UpdateZeroOutScheduleAsync(zeroOutSchedule);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteZeroOutSchedule(int id)
        {
            var zeroOutSchedule = await _zeroOutScheduleService.GetZeroOutScheduleByIdAsync(id);
            if (zeroOutSchedule == null)
            {
                return NotFound();
            }

            await _zeroOutScheduleService.DeleteZeroOutScheduleAsync(zeroOutSchedule);
            return NoContent();
        }
    }
}