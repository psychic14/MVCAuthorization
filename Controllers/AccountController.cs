using Microsoft.AspNetCore.Mvc;

namespace MVCAuthorization.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult Registor()
        {
            return View();

        }
    }
}
