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
            if (email == "admin@bill24.io" && password == "123") //?7YM)1OgRtr5
            {
                HttpContext.Session.SetString("emailId", email);
                error = 0;
            }
            else
            {
                HttpContext.Session.SetString("emailId", "");
                error = 1;
            }
            return Ok(error);
        }
    }
}
