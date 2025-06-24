using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KgyHoldingWebsite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        private readonly KgyDbContext _context;

        public PagesController(KgyDbContext context)
        {
            _context = context;
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchPages([FromQuery] string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return BadRequest("Query is empty.");

            query = query.ToLower();

            var result = await _context.Pages
                .Where(p =>
                    p.Title.ToLower().Contains(query) ||
                    p.Keywords.ToLower().Contains(query)
                )
                .Select(p => new { p.Title, p.Path })
                .ToListAsync();

            return Ok(result);
        }

    }
}
