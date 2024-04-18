using System;
using Microsoft.AspNetCore.Mvc;
using MvcFrontToBack.Data;
using MvcFrontToBack.Models;
using MvcFrontToBack.ViewModels;

namespace MvcFrontToBack.Controllers
{
	public class TeamController:Controller
	{
		 private DataContext dataContext;
        public TeamController()
		{
			dataContext = new DataContext();
            
        }
		public IActionResult Index()
		{
			
			return View(dataContext.Teams);
		}
	}
}

