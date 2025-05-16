using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Infra.Data;

namespace Project.Presentation.Areas.Admin.Pages.Users
{
    //[Authorize("Admin")]
    public class RoleManagementModel : PageModel
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly UserManager<User> _userManager;

        public RoleManagementModel(RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public List<Role> Roles { get; set; }

        public User user { get; set; }

        [BindProperty]
        public string Id { get; set; }
      
        public List<string> UserRoles { get; set; }

        [BindProperty]
        public List<string> SelectedRoles { get; set; }


        public async Task OnGet(string id)
        {
             user = await _userManager.FindByIdAsync(id);
          
           
            Roles =  _roleManager.Roles.Where(p => p.IsRemoved == false).ToList();
          
            UserRoles = (await _userManager.GetRolesAsync(user)).ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
             user = await _userManager.FindByIdAsync(Id);
             Roles =  _roleManager.Roles.Where(p => p.IsRemoved == false).ToList();
          
            if (Roles != null)
            {

            if (user != null) {
                  
                    foreach (var role in Roles)
                    {
                        if (SelectedRoles.Contains(role.Name))
                        {
                          if (!(await _userManager.IsInRoleAsync(user, role.Name)))
                          {
                                await _userManager.AddToRoleAsync(user, role.Name);
                          }           
                        }
                        else
                        {
                            if (await _userManager.IsInRoleAsync(user, role.Name))
                            {
                                await _userManager.RemoveFromRoleAsync(user, role.Name);
                            }
                        }

                    }
            }
            }
            else
            {
                return RedirectToPage("../Roles/Add");
            }
            return RedirectToPage("List");
        }
    }
}
