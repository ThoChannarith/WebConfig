using Microsoft.AspNetCore.Mvc;

namespace WebConfigTesting.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Login(string email, string password)
        {
            int error = 1;
            if (email == "admin@bill24.io" && password == "?7YM)1OgRtr5")
            {
                error = 0;
            }
            else
            {
                error = 1;
            }
            return Ok(error);
        }
    }
}
