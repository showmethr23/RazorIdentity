using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorIdentity.Areas.Identity.Pages.Account
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
