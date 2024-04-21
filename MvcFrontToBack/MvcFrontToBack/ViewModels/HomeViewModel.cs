using System;
using MvcFrontToBack.Models;

namespace MvcFrontToBack.ViewModels
{
	public class HomeViewModel
	{
		
		 public List<Feature> Features { get; set; }

		 public List<Service> Services { get; set; }
		public List<Client> Clients { get; set; }
		public List<Slide> Slides { get; set; }

    }

}
