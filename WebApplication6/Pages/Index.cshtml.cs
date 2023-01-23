using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication6.Models;

namespace WebApplication6.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly MyBlogContext _myBlogContext;
    public IndexModel(ILogger<IndexModel> logger, MyBlogContext myBlogContext)
    {
        _logger = logger;
        _myBlogContext = myBlogContext;
    }

    public void OnGet()
    {
        var post = (from p in _myBlogContext.Articles orderby p.Content descending select p).ToList();
        ViewData["post"] = post;
    }
}