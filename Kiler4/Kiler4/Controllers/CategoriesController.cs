using Microsoft.AspNetCore.Mvc;

namespace Kiler4.Controllers
{
	public class CategoriesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
