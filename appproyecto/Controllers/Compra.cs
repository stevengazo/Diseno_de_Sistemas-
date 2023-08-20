using Microsoft.AspNetCore.Mvc;

namespace appproyecto.Controllers
{
	public class Compra : Controller
	{
		public IActionResult GenerarPedido()
		{
			return View();
		}
	}
}
