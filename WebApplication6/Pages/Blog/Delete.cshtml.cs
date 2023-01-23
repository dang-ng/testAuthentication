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
    public class DeleteModel : PageModel
    {
        private readonly WebApplication6.Models.MyBlogContext _context;

        public DeleteModel(WebApplication6.Models.MyBlogContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Article Article { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Articles == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.FirstOrDefaultAsync(m => m.Id == id);

            if (article == null)
            {
                return NotFound();
            }
            else 
            {
                Article = article;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Articles == null)
            {
                return NotFound();
            }
            var article = await _context.Articles.FindAsync(id);

            if (article != null)
            {
                Article = article;
                _context.Articles.Remove(Article);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
