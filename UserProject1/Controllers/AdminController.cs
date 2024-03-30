using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserProject1.Models;

namespace UserProject1.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<AppUser> userManager;
        public AdminController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(userManager.Users);
        }
    }
}
