using System;
using System.Web.Mvc;

namespace Demo.SquishIt.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}