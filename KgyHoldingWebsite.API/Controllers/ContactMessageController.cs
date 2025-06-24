using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;
using KgyHoldingWebsite.Application;
using System.Threading.Tasks;
using KgyHoldingWebsite.Application.Interfaces;


namespace KgyHoldingWebsite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactMessageController : ControllerBase
    {
        private readonly KgyDbContext _context;
        private readonly IContactMessageService _contactService;

        public ContactMessageController(KgyDbContext context, IContactMessageService contactService)
        {
            _context = context;
            _contactService = contactService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var messages = await _context.ContactMessages.ToListAsync();
            return Ok(messages);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ContactMessage item)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _contactService.SaveMessageAsync(item);
            await _contactService.SendEmailAsync(item);

            return Ok(new { success = true, message = "Mesaj başarıyla gönderildi." });
        }
    }
}

