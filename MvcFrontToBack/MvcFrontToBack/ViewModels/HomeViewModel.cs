using System;
using MvcFrontToBack.Models;

namespace MvcFrontToBack.ViewModels
{
	public class HomeViewModel
	{
		
		public List<Card>? Cards { get; set; }

		public List<Service>? Services { get; set; }

		public List<Team>? Teams { get; set; }

    }

}
