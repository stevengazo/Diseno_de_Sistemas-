using Microsoft.AspNetCore.Mvc;

namespace appproyecto.Controllers
{
	public class CompraController : Controller
	{
		public IActionResult GenerarFactura()
		{
			return View();
		}
		public IActionResult GenerarCompra()
		{
			return View();
		}
	}
}
