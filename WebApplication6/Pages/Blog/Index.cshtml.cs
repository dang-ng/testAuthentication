using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.Pages_Blog
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication6.Models.MyBlogContext _context;

        public IndexModel(WebApplication6.Models.MyBlogContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Articles != null)
            {
                Article = await _context.Articles.ToListAsync();
            }
        }
    }
}
