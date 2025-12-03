using Microsoft.AspNetCore.Mvc;

namespace DotnetCore_MVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
