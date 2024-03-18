using ClassroomManagerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassroomManagerAPI.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Facility> Facilities { get; set; }
	}
}
