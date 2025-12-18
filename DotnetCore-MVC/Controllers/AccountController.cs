using Microsoft.AspNetCore.Mvc;

namespace DotnetCore_MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
