using Resume.Areas.Identity.Data;
using Resume.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Areas.Identity.Pages.Admin.Users
{
    [Authorize("ViewUsers")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<ApplicationRole> _roleManager;
        public IAuthorizationService _authorizationService;

        public IndexModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context, RoleManager<ApplicationRole> roleManager, IAuthorizationService authorizationService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
            _authorizationService = authorizationService;
        }

        public Dictionary<string, string> GetUsers { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            // get all the users. usermanager is useless to get the list, therefore,
            // use usermanager's parent.
            var getUsers = await _context.Users.Select(x => x.UserName).ToListAsync();
            Dictionary<string, string> getusers = new Dictionary<string, string>();
            foreach (var user in getUsers)
            {
                var IUser = await _userManager.FindByNameAsync(user); // Get the single user from usermanager.

                // If the user belongs to a role, attach the role to the user 

                IList<string> userRoles = await _userManager.GetRolesAsync(IUser);
                if (userRoles.Count != 0)
                {
                    getusers.Add(IUser.UserName, userRoles[0]);
                }
                else
                {
                    getusers.Add(IUser.UserName, "none");

                }
            }
            GetUsers = getusers;
            return Page();
        }

        public async Task<IActionResult> OnPostAdd(string NewUserName, string NewUserEmail, string NewUserPassword)
        {
            ApplicationUser user = new ApplicationUser();
            user.UserName = NewUserName;
            user.Email = NewUserEmail;
            user.PasswordHash = NewUserPassword.GetHashCode().ToString();
            await _userManager.CreateAsync(user);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDelete(string NameToDelete)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(NameToDelete);
            await _userManager.DeleteAsync(user);
            return RedirectToPage();
        }


        [TempData]
        public string DeleteUser { get; set; }
        public IActionResult OnPostEdit(string NameToDelete)
        {
            DeleteUser = NameToDelete;
            return RedirectToPage($"Edit", "Get");
        }
    }
}
