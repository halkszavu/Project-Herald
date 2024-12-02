using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
	public class HeraldDataContext : DbContext
	{
		public DbSet<Concert> Concertes { get; set; }
		public DbSet<Composer> Composers { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Orchestra> Orchestras { get; set; }
		public DbSet<Period> Periods { get; set; }
		public DbSet<Piece> Pieces { get; set; }
		public DbSet<Location> Locations { get; set; }

		public HeraldDataContext(DbContextOptions<HeraldDataContext> options) : base(options) {	}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);			
		}
	}
}
