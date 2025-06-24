using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
public class BrandController : ControllerBase
{
    private readonly KgyDbContext _context;
    public BrandController(KgyDbContext context) => _context = context;

    [HttpGet] public async Task<IActionResult> Get() => Ok(await _context.Brands.ToListAsync());
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Brand item)
    {
        _context.Brands.Add(item);
        await _context.SaveChangesAsync();
        return Ok(item);
    }
}
