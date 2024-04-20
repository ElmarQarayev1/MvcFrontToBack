using System;
using Microsoft.EntityFrameworkCore;
using MvcFrontToBack.Models;

namespace MvcFrontToBack.Data
{
	public class AppDbContext : DbContext
	{

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
		public DbSet<Feature> Features { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<ProjectImage> ProjectImages { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Team> Teams { get; set; }
		public DbSet<TeamIcon> TeamIcons { get; set; }
	}
}
