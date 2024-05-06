using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeaklyTypedForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginPost(string Username, string Password)
        {
            ViewBag.user = Username;
            ViewBag.pass = Password;
            return View();
        }
    }
}
