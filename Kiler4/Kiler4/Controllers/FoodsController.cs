using Microsoft.AspNetCore.Mvc;

namespace Kiler4.Controllers
{
	public class FoodsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
