using System;
namespace MvcFrontToBack.Models
{
	public class Team
	{
		public int Id { get; set; }
		public int ImgPath { get; set; }
		public string Name { get; set; }
		public string Position { get; set; }
		public string Desc { get; set; }
		public List<TeamIcon> TeamIcons { get; set; }
	}
}

