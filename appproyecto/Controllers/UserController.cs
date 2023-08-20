using Microsoft.AspNetCore.Mvc;

namespace appproyecto.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Info()
        {
            return View();
        }

        public IActionResult CambioContrasena()
        {
            return View();
        }

        public IActionResult UserInfo()
        {
            return View();
        }

    }
}
