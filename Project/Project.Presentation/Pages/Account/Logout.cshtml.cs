using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Infra.Data;

namespace Project.Presentation.Pages.Account
{
    public class LogoutModel : PageModel
    {
      
        private readonly SignInManager<User> _signInManager;

        public LogoutModel(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IActionResult> OnGet()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
          
                await _signInManager.SignOutAsync();

            }

            return Redirect("/account/login");
        }
    }
}
