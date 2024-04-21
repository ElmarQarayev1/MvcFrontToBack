using System;
using Microsoft.AspNetCore.Mvc;
using MvcFrontToBack.Data;

namespace MvcFrontToBack.Controllers
{
	public class ServiceController:Controller
	{
		AppDbContext _context;
		public ServiceController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View(_context.Services.ToList());
		}
	}
}

