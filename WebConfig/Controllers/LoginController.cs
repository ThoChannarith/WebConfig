using Microsoft.AspNetCore.Mvc;

namespace WebConfigTesting.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
