using System;
using System.Web.Mvc;

namespace Demo.Combres.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}