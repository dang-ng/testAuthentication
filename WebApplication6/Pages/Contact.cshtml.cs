using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication6.Models;

namespace WebApplication6.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty] 
        public CustomerInfo customerInfo { get; set; }
        [BindProperty] public IFormFile FileUpload { get; set; }
        
        public void OnGet()
        {
        }

        public void OnPost()
        {
            
        }
    }
}
