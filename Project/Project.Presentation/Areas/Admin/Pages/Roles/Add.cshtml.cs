using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Domain.Repository.Role;
using Project.Infra.Data;

namespace Project.Presentation.Areas.Admin.Pages.Roles
{
    //[Authorize("Admin")]
    public class AddModel : PageModel
    {
        private readonly RoleManager<Role> _roleManager;

        public AddModel(RoleManager<Role> roleManager, IRoleRepository repository)
        {
            _roleManager = roleManager;
        }

        [BindProperty]
        public string Name { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {

                Role role = new()
                {
                    Name = Name
                };
                var result = await _roleManager.CreateAsync(role);

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