using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KgyHoldingWebsite.Application.Dtos;

namespace KgyHoldingWebsite.Application.Interfaces
{
    public interface ICompanyHistoryService
    {
        List<CompanyHistoryDto> GetAll();
    }

}
