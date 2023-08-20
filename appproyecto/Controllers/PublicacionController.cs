using Microsoft.AspNetCore.Mvc;

namespace appproyecto.Controllers
{
    public class PublicacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Agregar()
        {
            return View();
        }
        public IActionResult Ver()
        {
            return View();
        }
    }
}
