using System;
using Microsoft.AspNetCore.Mvc;

namespace SumNumber.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Error()
		{
			return View();
		}

		public IActionResult sum()
		{
			return View();
		}

		[HttpPost]
		public IActionResult add()
		{
			int num1 = Convert.ToInt32(HttpContext.Request.Form["txtFirst"].ToString());
			int num2 = Convert.ToInt32(HttpContext.Request.Form["txtSecond"].ToString());
			int num3 = Convert.ToInt32(HttpContext.Request.Form["txtThird"].ToString());
			int result = num1 + num2 + num3;
			ViewBag.SumResult = result.ToString();
			return View("sum");
		}
	}
}
