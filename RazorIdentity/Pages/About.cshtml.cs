using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorIdentity.Pages
{
    [Authorize(Roles = "Admin")]
    public class AboutModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Your application description page.";
        }
    }
}
