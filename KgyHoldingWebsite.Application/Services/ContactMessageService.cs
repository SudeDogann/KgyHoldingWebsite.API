using KgyHoldingWebsite.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;
using System.Net;
using System.Net.Mail;

public class ContactMessageService : IContactMessageService
{
    private readonly KgyDbContext _context;
    private readonly IConfiguration _configuration;

    public ContactMessageService(KgyDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    public async Task SaveMessageAsync(ContactMessage message)
    {
        _context.ContactMessages.Add(message);
        await _context.SaveChangesAsync();
    }

    public async Task SendEmailAsync(ContactMessage message)
    {
        var smtpClient = new SmtpClient(_configuration["Smtp:Host"])
        {
            Port = int.Parse(_configuration["Smtp:Port"]),
            Credentials = new NetworkCredential(_configuration["Smtp:Username"], _configuration["Smtp:Password"]),
            EnableSsl = true,
        };

        var mailMessage = new MailMessage
        {
            From = new MailAddress(_configuration["Smtp:Username"]),
            Subject = $"İletişim Formu: {message.Subject}",
            Body = $"Ad Soyad: {message.FullName}\nEmail: {message.Email}\n\nMesaj:\n{message.Message}",
            IsBodyHtml = false,
        };
        mailMessage.To.Add(_configuration["Smtp:ToEmail"]);

        await smtpClient.SendMailAsync(mailMessage);
    }
}
