using Microsoft.EntityFrameworkCore;
using KgyHoldingWebsite.Models; 

namespace KgyHoldingWebsite.Data 
{
    public class KgyDbContext : DbContext
    {
        public KgyDbContext(DbContextOptions<KgyDbContext> options) : base(options)
        {
        }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<CompanyHistory> CompanyHistories { get; set; }
        public DbSet<BoardMember> BoardMembers { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ForeignPartner> ForeignPartners { get; set; }
        public DbSet<WhyKgy> WhyKgys { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<CorporateGovernance> CorporateGovernances { get; set; }
        public DbSet<LifeAtKgy> LifeAtKgys { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<PageInfo> Pages { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }


    }
}
