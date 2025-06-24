using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;

namespace KgyHoldingWebsite.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AboutUsController : ControllerBase
{
    private readonly KgyDbContext _context;

    public AboutUsController(KgyDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get() =>
        Ok(await _context.AboutUs.ToListAsync());

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] AboutUs item)
    {
        _context.AboutUs.Add(item);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _context.AboutUs.FindAsync(id);
        if (item == null)
            return NotFound();

        _context.AboutUs.Remove(item);
        await _context.SaveChangesAsync();

        return NoContent();
    }

}

