using System;
namespace MvcFrontToBack.Models
{
	public class ProjectImage
	{
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public Project Project { get; set; }
        public bool IsMain { get; set; }
    }
}
