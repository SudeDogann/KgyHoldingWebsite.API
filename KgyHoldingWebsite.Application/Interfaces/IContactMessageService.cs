using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;

namespace KgyHoldingWebsite.Application.Interfaces
{
    public interface IContactMessageService
    {
        Task SaveMessageAsync(ContactMessage message);
        Task SendEmailAsync(ContactMessage message);
    }

}
