﻿using Microsoft.AspNetCore.Mvc;

namespace Kiler4.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
