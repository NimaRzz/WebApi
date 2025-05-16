using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Application.Common.Pagination;
using Project.Infra.Data;

namespace Project.Presentation.Areas.Admin.Pages.Users
{
    //[Authorize("Admin")]
    public class ListModel : PageModel
    {
        private readonly UserManager<User> _userManager;

        public ListModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public List<User> Users { get; set; }
       

        public void OnGet(int Page = 1, int PageSize = 20)
        {

            int totalPage = 0;
          
            var paginationUsers = _userManager.Users.ToPaged(Page, PageSize, out totalPage);
          
            if(paginationUsers.IsSuccess)
            {
                Users = paginationUsers.Data.ToList();
            }
        }

        public async Task<IActionResult> OnPostAsync(string Id)
        {

            var user = await _userManager.FindByIdAsync(Id);

            if (user != null)
            {
                await _userManager.DeleteAsync(user);
            }
            return RedirectToPage();


        }
    }
}
