using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/[controller]")]
public class CorporateGovernanceController : ControllerBase
{
    private readonly KgyDbContext _context;
    public CorporateGovernanceController(KgyDbContext context) => _context = context;

    [HttpGet] public async Task<IActionResult> Get() => Ok(await _context.CorporateGovernances.ToListAsync());
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CorporateGovernance item)
    {
        _context.CorporateGovernances.Add(item);
        await _context.SaveChangesAsync();
        return Ok(item);
    }
}
