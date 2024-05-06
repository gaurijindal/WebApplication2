using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var user = new StudentModel();
            {
                Id = 12015730,
                Password = "abc"
            };
            return View(user);
        }
    }
}
