using Microsoft.AspNetCore.Mvc;

namespace appproyecto.Controllers
{
    public class CategoriasController : Controller
    {
        public IActionResult Categorias()
        {
            return View();
        }
    }
}
