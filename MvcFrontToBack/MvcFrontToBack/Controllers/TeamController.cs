using System;
using Microsoft.AspNetCore.Mvc;
using MvcFrontToBack.Models;
using MvcFrontToBack.ViewModels;

namespace MvcFrontToBack.Controllers
{
	public class TeamController:Controller
	{
        List<Team> Teams = new List<Team>();
        public TeamController()
		{
            Teams = new List<Team>()
        {
            new Team
            {
                Id=1,
                Name="lady ibrahim",
                ShortDescription="telebe",
                LongDescription="universitet telebesi"
            },
            new Team
            {
                Id=2,
                Name="bigLady ibrahim",
                ShortDescription="telebe",
                LongDescription="universitet telebesi"
            },
            new Team
            {
                Id=3,
                Name="xanim ibrahim",
                ShortDescription="telebe",
                LongDescription="universitet telebesi"
            }
        };
        }
		public IActionResult Index()
		{
            HomeViewModel hv = new HomeViewModel();
            hv.Teams = Teams;
			return View(hv);
		}
	}
}

