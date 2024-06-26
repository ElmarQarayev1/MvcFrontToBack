﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcFrontToBack.Data;
using MvcFrontToBack.Models;
using MvcFrontToBack.ViewModels;

namespace MvcFrontToBack.Controllers;

public class HomeController : Controller
{
    private AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        HomeViewModel hv = new HomeViewModel()
        {
            Features = _context.Features.ToList(),
            Services=_context.Services.ToList(),
            Clients=_context.Clients.ToList(),
            Slides=_context.Slides.OrderByDescending(x=>x.Order).ToList()
        };
       return View(hv);
    }
}