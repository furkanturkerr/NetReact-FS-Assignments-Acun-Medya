using Business.DTOs.Application;
using Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private readonly IApplicationService _service;

        public ApplicationsController(IApplicationService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateApplicationDto dto)
        {
            var result = await _service.CreateAsync(dto);
            return Ok(result);
        }
    }
}