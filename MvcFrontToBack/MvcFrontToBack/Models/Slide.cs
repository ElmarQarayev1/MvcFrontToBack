using System;
namespace MvcFrontToBack.Models
{
	public class Slide
	{
		public int Id { get; set; }
		public string Img { get; set; }
		public string Title1 { get; set; }
		public string Title2 { get; set; }
		public string Desc { get; set; }
		public string ButtonHref { get; set; }
		public string ButtonName { get; set; }
		public int Order { get; set; }
	}
} 

