using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monitor = Data.Models.Monitor;

namespace Web_Api_Lesson1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitorsController : ControllerBase
    {
        private readonly ShopDbContext context;
        private readonly IMonitorService monitorService;
        public MonitorsController(ShopDbContext context, IMonitorService monitorService)
        {
            this.context = context;
            this.monitorService = monitorService;
        }
        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(monitorService.GetAll());
        }
        [HttpGet("single/{id}")]
        public IActionResult Get(int id)
        {
            var monitor = monitorService.GetById(id);

            if(monitor == null)return NotFound();

            return Ok(monitor);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]MonitorDto monitor)
        {
            if (!ModelState.IsValid) return BadRequest();
            await monitorService.Create(monitor);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] MonitorDto monitor)
        {
            if (!ModelState.IsValid) return BadRequest();
            await monitorService.Edit(monitor);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await monitorService.Delete(id);

            return Ok();
        }
    }
}
