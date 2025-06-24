using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
public class SectorController : ControllerBase
{
    private readonly KgyDbContext _context;
    public SectorController(KgyDbContext context) => _context = context;

    [HttpGet] public async Task<IActionResult> Get() => Ok(await _context.Sectors.ToListAsync());
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Sector item)
    {
        _context.Sectors.Add(item);
        await _context.SaveChangesAsync();
        return Ok(item);
    }
}
