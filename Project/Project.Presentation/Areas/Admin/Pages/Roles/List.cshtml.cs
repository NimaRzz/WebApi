using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Common.Pagination;
using Project.Infra.Data;

namespace Project.Presentation.Areas.Admin.Pages.Roles
{
    //[Authorize("Admin")]
    public class ListModel : PageModel
    {
        private readonly RoleManager<Role> _roleManager;

        public ListModel(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public List<Role> Roles { get; set; }
        public void OnGet(int Page = 1, int PageSize = 20)
        {
            int totalPage = 0;

            var paginationRoles = _roleManager.Roles.Where(p => p.IsRemoved == false).ToPaged(Page, PageSize, out totalPage);

            if (paginationRoles.IsSuccess)
            {
                Roles = paginationRoles.Data.ToList();
            }
        }

        public async Task<IActionResult> OnPostAsync(string Name)
        {
            var role = await _roleManager.FindByNameAsync(Name);

            if (role != null)
            {
                await _roleManager.DeleteAsync(role);
            }
            return RedirectToPage();
        }
    }
}
