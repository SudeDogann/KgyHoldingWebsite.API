using KgyHoldingWebsite.Application.Interfaces;
using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class CompanyHistoryController : ControllerBase
{
    private readonly ICompanyHistoryService _service;

    public CompanyHistoryController(ICompanyHistoryService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var data = _service.GetAll();
        return Ok(data);
    }
}

