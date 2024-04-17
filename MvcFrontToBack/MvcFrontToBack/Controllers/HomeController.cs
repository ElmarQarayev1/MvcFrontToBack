using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MvcFrontToBack.Controllers;

public class HomeController : Controller
{
   
    public IActionResult Index()
    {
        return View();
    }
  
}
