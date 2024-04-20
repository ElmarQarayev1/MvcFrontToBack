using System;
using Microsoft.AspNetCore.Mvc;

using MvcFrontToBack.Models;
using MvcFrontToBack.ViewModels;

namespace MvcFrontToBack.Controllers
{
	public class TeamController:Controller
	{
		
        public TeamController()
		{
			
            
        }
		public IActionResult Index()
		{
			
			return View();
		}
	}
}

