using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KgyHoldingWebsite.Models
{
    public class PageInfo
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Path { get; set; }
        public string Keywords { get; set; } = string.Empty;
    }
}
