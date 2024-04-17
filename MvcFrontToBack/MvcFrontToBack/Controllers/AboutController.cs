using System;
using Microsoft.AspNetCore.Mvc;

namespace MvcFrontToBack.Controllers
{
	public class AboutController:Controller
	{
        public IActionResult Index()
        {
            return View();
        }
    }
}

