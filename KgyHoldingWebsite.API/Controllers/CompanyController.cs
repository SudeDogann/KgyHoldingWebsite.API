using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
public class CompanyController : ControllerBase
{
    private readonly KgyDbContext _context;
    public CompanyController(KgyDbContext context) => _context = context;

    [HttpGet] public async Task<IActionResult> Get() => Ok(await _context.Companies.ToListAsync());
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Company item)
    {
        _context.Companies.Add(item);
        await _context.SaveChangesAsync();
        return Ok(item);
    }
}
