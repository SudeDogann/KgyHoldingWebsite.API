using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/[controller]")]
public class ForeignPartnerController : ControllerBase
{
    private readonly KgyDbContext _context;
    public ForeignPartnerController(KgyDbContext context) => _context = context;

    [HttpGet] public async Task<IActionResult> Get() => Ok(await _context.ForeignPartners.ToListAsync());
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ForeignPartner item)
    {
        _context.ForeignPartners.Add(item);
        await _context.SaveChangesAsync();
        return Ok(item);
    }
}
