using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFrontToBack.Data;
using MvcFrontToBack.Models;
using MvcFrontToBack.ViewModels;

namespace MvcFrontToBack.Controllers
{
	public class TeamController:Controller
	{
		AppDbContext _context;
        public TeamController(AppDbContext context)
		{
			_context = context;  
        }
		public IActionResult Index()
		{
		    var elem = _context.Teams.Include(x => x.TeamIcons).ToList();
			return View(elem);
		}
	}
}
