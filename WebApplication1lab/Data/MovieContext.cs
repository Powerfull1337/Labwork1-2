using Microsoft.EntityFrameworkCore;
using WebApplication1lab.Models;

namespace WebApplication1lab.Data
{
	public class MovieContext : DbContext
	{
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Purchase> Purchases { get; set; }
		public MovieContext(DbContextOptions<MovieContext> options) 
			: base(options)
		{

		}


	}
}
