using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Infra.Data;

namespace Project.Presentation.Areas.Admin.Pages.Users
{
    //[Authorize("Admin")]
    public class UpdateModel : PageModel
    {
        private readonly UserManager<User> _userManager;

        public UpdateModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public string UserName { get; set; }
        
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string? Password { get; set; }

        [BindProperty]
        public string Id { get; set; }

        public async Task<IActionResult> OnGetAsync(string Id)
        {
            User user = await _userManager.FindByIdAsync(Id);
            if (user == null)
            {
              
                return RedirectToPage("List");
            }
           
            UserName = user.UserName;
            Email = user.Email;
           
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(Id);
               
                    user.UserName = UserName;
                    user.Email = Email;
                   
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded && !string.IsNullOrEmpty(Password))
                    {
                        await _userManager.RemovePasswordAsync(user);
                        await _userManager.AddPasswordAsync(user, Password);
                    }
                    if (result.Succeeded)
                    {
                        return RedirectToPage("List");
                    }
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    
                
            }
            return Page();
        }
    }
}
