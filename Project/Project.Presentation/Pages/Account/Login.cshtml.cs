using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Infra.Data;

namespace Project.Presentation.Pages.Account
{
    public class LoginModel : PageModel
    {

        private readonly SignInManager<User> _signInManager;

        public LoginModel(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string Password { get; set; }  
        
        [BindProperty]
        public bool RememberMe { get; set; }

        [BindProperty]
        public string? ReturnUrl { get; set; }


        public IActionResult OnGet()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return Redirect("/");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
               var result = await _signInManager.PasswordSignInAsync(UserName, Password, RememberMe, false);

                if (result.Succeeded)
                {
                    return Redirect(ReturnUrl ?? "/");
                }
                ModelState.AddModelError("", "Invalid Username or Password");
            }
            return Page();
        }
    }
}
