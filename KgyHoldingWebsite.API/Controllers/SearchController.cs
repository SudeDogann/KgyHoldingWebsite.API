using KgyHoldingWebsite.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KgyHoldingWebsite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet]
        public IActionResult Search([FromQuery] string query)
        {
            var results = _searchService.Search(query);
            return Ok(results);
        }
    }

}
