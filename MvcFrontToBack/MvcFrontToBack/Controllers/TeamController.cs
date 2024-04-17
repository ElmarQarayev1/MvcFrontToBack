using System;
using Microsoft.AspNetCore.Mvc;

namespace MvcFrontToBack.Controllers
{
	public class TeamController:Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		
	}
}

