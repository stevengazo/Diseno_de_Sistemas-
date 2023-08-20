using Microsoft.AspNetCore.Mvc;

namespace appproyecto.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Buscar()
        {
            return View();
        }
        public IActionResult VerProducto()
        {
            return View();
        }

       
    }
}
