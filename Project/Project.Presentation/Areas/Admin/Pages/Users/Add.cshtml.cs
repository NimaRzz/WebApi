using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Infra.Data;

namespace Project.Presentation.Areas.Admin.Pages.Users
{
    //[Authorize("Admin")]
    public class AddModel : PageModel
    {

        private readonly UserManager<User> _userManager;

        public AddModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage="Email Format Incorrect")]
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                User user = new()
                {
                    UserName = UserName,
                    Email = Email
                };

                IdentityResult result = await _userManager.CreateAsync(user, Password);
                if (result.Succeeded)
                {
                    return RedirectToPage("List");
                }
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return Page();
        }
    }
}
