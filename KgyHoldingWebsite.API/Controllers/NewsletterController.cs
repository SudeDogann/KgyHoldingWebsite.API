using KgyHoldingWebsite.Application.Dtos;
using KgyHoldingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using KgyHoldingWebsite.Data;

namespace KgyHoldingWebsite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsletterController : ControllerBase
    {
        private readonly KgyDbContext _context;
        private readonly EmailService _emailService;

        public NewsletterController(KgyDbContext context, EmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe([FromBody] NewsletterDto model)
        {
            if (string.IsNullOrWhiteSpace(model.Email))
                return BadRequest("E-posta adresi gerekli.");

            var newsletter = new Newsletter
            {
                Email = model.Email,
                SubscribedAt = DateTime.UtcNow
            };

            _context.Newsletters.Add(newsletter);
            await _context.SaveChangesAsync();

            // E-posta gönder
            await _emailService.SendEmailAsync(
                model.Email,
                "Bülten Aboneliğiniz Alındı",
                "<p>Merhaba, bültenimize abone olduğunuz için teşekkür ederiz!</p>"
            );

            return Ok(new { message = "Abonelik başarılı, e-posta gönderildi." });
        }
    }
}


