using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcFrontToBack.Data;
using MvcFrontToBack.ViewModels;

namespace MvcFrontToBack.Controllers
{
	public class PortfolioController:Controller
	{
		private AppDbContext _context;
		public PortfolioController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			PortfolioViewModel pv = new PortfolioViewModel()
			{
				Categories = _context.Categories.ToList(),
                Projects = _context.Projects.Include(x => x.Category).Include(x => x.ProjectImages).ToList()
            };
			return View(pv);
		}
	}
}
