using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KgyHoldingWebsite.Application.Dtos;
using KgyHoldingWebsite.Application.Interfaces;
using KgyHoldingWebsite.Data;

namespace KgyHoldingWebsite.Application.Services
{
    public class CompanyHistoryService : ICompanyHistoryService
    {
        private readonly KgyDbContext _context;

        public CompanyHistoryService(KgyDbContext context)
        {
            _context = context;
        }

        public List<CompanyHistoryDto> GetAll()
        {
            return _context.CompanyHistories
                .OrderBy(h => h.Year)
                .Select(h => new CompanyHistoryDto
                {
                    Year = h.Year,
                    Description = h.Description
                }).ToList();
        }
    }

}
