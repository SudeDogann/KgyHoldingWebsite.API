using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/[controller]")]
public class AnnouncementController : ControllerBase
{
    private readonly KgyDbContext _context;
    public AnnouncementController(KgyDbContext context) => _context = context;

    [HttpGet] public async Task<IActionResult> Get() => Ok(await _context.Announcements.ToListAsync());
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Announcement item)
    {
        _context.Announcements.Add(item);
        await _context.SaveChangesAsync();
        return Ok(item);
    }
}
