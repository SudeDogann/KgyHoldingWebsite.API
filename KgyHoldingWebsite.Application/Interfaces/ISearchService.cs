using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KgyHoldingWebsite.Application.Dtos;


namespace KgyHoldingWebsite.Application.Interfaces
{
    public interface ISearchService
    {
        List<SearchResultDto> Search(string query);
    }
}
