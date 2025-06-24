using KgyHoldingWebsite.Application.Interfaces;
using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Application.Dtos;


public class SearchService : ISearchService
{
    private readonly KgyDbContext _context;

    public SearchService(KgyDbContext context)
    {
        _context = context;
    }

    public List<SearchResultDto> Search(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return new List<SearchResultDto>();

        return _context.Pages
            .Where(p =>
                p.Title.Contains(query) ||
                p.Keywords.Contains(query)
            )
            .Select(p => new SearchResultDto
            {
                Title = p.Title,
                Url = p.Path,
                Type = "Page"
            })
            .ToList();
    }
}
