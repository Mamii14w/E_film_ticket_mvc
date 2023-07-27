
using E_film_ticket.Models;
using Microsoft.EntityFrameworkCore;

namespace E_film_ticket.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ActorMovie>().HasKey(am => new {
				am.ActorId,
				am.MovieId });

			modelBuilder.Entity<ActorMovie>().HasOne(m => m.MovieModel).WithMany(am => am.Actor_Movie).HasForeignKey(m => m.MovieId);
			 
			modelBuilder.Entity<ActorMovie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);

           			
			base.OnModelCreating(modelBuilder);
		}
	    public DbSet<Actor> Actors { get; set; }
		public DbSet<MovieModel> Movies { get; set; }
		public DbSet<ActorMovie> actorMovies { get; set; }
		public DbSet<Cinema> cinemas { get; set; }
		public DbSet<Producer> producers { get; set; }

	}
}
