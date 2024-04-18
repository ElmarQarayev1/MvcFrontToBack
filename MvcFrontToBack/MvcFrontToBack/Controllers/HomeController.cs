﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcFrontToBack.Data;
using MvcFrontToBack.Models;
using MvcFrontToBack.ViewModels;

namespace MvcFrontToBack.Controllers;

public class HomeController : Controller
{
    List<Service> Services = new List<Service>();
    List<Card> Cards = new List<Card>();
    public HomeController()
    {
        Cards = new List<Card>()
        {
             new Card
             {
                 Id=1,
                 Name="isler",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Card
             {
                 Id=2,
                 Name="calismalar",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Card
             {
                 Id=3,
                 Name="is yerleri",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Card
             {
                 Id=4,
                 Name="datalar",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Card
             {
                 Id=5,
                 Name="melumatlar",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Card
             {
                 Id=6,
                 Name="is birlikleri",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
        };
        Services = new List<Service>()
           {
             new Service
             {
                 Id=1,
                 Name="pb302",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Service
             {
                 Id=2,
                 Name="pb301",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Service
             {
                 Id=3,
                 Name="pb300",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
        };
        
}
    public IActionResult Index()
    {
        HomeViewModel hv = new HomeViewModel();
        hv.Services = Services;
        hv.Cards = Cards;
       return View(hv);
    }
}
