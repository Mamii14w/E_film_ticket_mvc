namespace E_film_ticket.Models
{
	public class ActorMovie
	{

		public int ActorId { get; set; }
		public Actor Actor { get; set; }
		public int MovieId { get; set; }
		public MovieModel MovieModel { get; set; }
	}
}