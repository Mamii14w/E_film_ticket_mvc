using E_film_ticket.Data.Enums;
using E_film_ticket.Models;

namespace E_film_ticket.Data
{
	public class AppDbInitialize
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using (var ServiceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = ServiceScope.ServiceProvider.GetService<AppDbContext>();

				if (!context.cinemas.Any())
				{
					context.cinemas.AddRange(new List<Cinema>()
					{
						new Cinema()
						{
							logo = "../Images/logo1.png",
							CName = "Alem cinema",
							Description = "This is alem..."
						},
						new Cinema()
						{
							logo = "../Images/logo2.png",
							CName = "Ethio Cinema",
							Description = "this is ethio..."
						}

					}
					);
					context.SaveChanges();
				}
				if (!context.Actors.Any())
				{
					context.Actors.AddRange(new List<Actor>()
					{
						new Actor()
						{
                         pictureYRL = "../Images/selam_tariku.jpg",
						 FullName  = "Tariku,Eyob adnd Tariku",
						 Bio = "All are my favoirite"
						},
						new Actor()
						{
                        pictureYRL = "../Images/Iyob.jpg",
						FullName = "Eyob Dawit",
						Bio = "Eyob dawit has so many films"
						}
				   }
					);
				}
				if (!context.producers.Any())
				{
					context.producers.AddRange(new List<Producer>()
					{
						new Producer()
						{
							ProfilePic = "../Images/turk.jpg",
							FullName = "Al-alall",
							Biography = "he is a best producer"
						},
						new Producer()
						{
							ProfilePic = "../Images/yared.jpg",
							FullName = "Yared Negu",
							Biography = "he is producer"
						}
					}
					);
					context.SaveChanges();
				}
				if (context.actorMovies.Any())
				{
					context.actorMovies.AddRange(new List<ActorMovie>()
					{
						new ActorMovie()
						{
							ActorId = 11,
							MovieId = 6
						},
						new ActorMovie()
						{
							ActorId = 12,
							MovieId = 7
						}
					}

					);
					context.SaveChanges();
				}
				if (!context.Movies.Any())
				{
					context.Movies.AddRange(new List<MovieModel>()
					{
					new MovieModel()
					{
					Name = "ERK YIHUN",
					Description = "Its all about peace ",
					price = 50,
					Image = "../Images/logo1.png",
					StartDate = DateTime.Now,
				    EndDate = DateTime.Now.AddDays(2),
					MovieCatagory = MovieCtacory.Action,
					CinemaId = 1,
					ProducerId = 1
					},
						new MovieModel()
					{
					Name = "Hello",
					Description = "Its all about Phone generation ",
					price = 50,
					Image = "../Images/logo1.png",
					StartDate = DateTime.Now,
					EndDate = DateTime.Now.AddDays(1),
					MovieCatagory = MovieCtacory.Documentary,
					CinemaId = 2,
					ProducerId = 1
					}
					}
				);
				     context.SaveChanges();
				}
		}
		}
	}
}