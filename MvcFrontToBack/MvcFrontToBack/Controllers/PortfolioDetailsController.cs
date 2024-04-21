using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFrontToBack.Data;
using MvcFrontToBack.ViewModels;

namespace MvcFrontToBack.Controllers
{
	public class PortfolioDetailsController:Controller
	{
		AppDbContext _context;
		public PortfolioDetailsController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Index(int id)
		{
			var project = _context.Projects.Include(x => x.Category).Include(x => x.ProjectImages).ToList().Find(x => x.Id == id);
			if (project == null)
			{
				TempData["error"] = "Project not found by given id";
				return RedirectToAction("error");
			}
            return View(project);
		}
		public IActionResult Error()
		{
			return View();
		}
	}
}
