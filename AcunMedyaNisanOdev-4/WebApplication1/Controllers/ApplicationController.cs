using AutoMapper;
using Business.DTOs.Bootcamp;
using Business.Services.Interfaces;
using DTOs.Application;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;

namespace WebApplication1.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ApplicationController : ControllerBase
{
    private readonly IApplicationService _service;

    public ApplicationController(IApplicationService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _service.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ApplicationRequest request)
    {
        await _service.AddAsync(request);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] ApplicationRequest request)
    {
        await _service.UpdateAsync(id, request);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }
}

