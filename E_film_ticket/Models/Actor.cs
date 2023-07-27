using System.ComponentModel.DataAnnotations;

namespace E_film_ticket.Models
{
	public class Actor
	{
        [Key]
        public int Aid { get; set; }
        [Display(Name = "Profile picture url")]
        public String  pictureYRL { get; set; }
        [Display(Name = "Full Name")]
        public String  FullName { get; set; }
        [Display(Name = "Boigraphy")]
        public String Bio { get; set; }
        public List<ActorMovie>  Actors_Movies { get; set; }

    }

}
