using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/[controller]")]
public class WhyKgyController : ControllerBase
{
    private readonly KgyDbContext _context;
    public WhyKgyController(KgyDbContext context) => _context = context;

    [HttpGet] public async Task<IActionResult> Get() => Ok(await _context.WhyKgys.ToListAsync());
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] WhyKgy item)
    {
        _context.WhyKgys.Add(item);
        await _context.SaveChangesAsync();
        return Ok(item);
    }
}
