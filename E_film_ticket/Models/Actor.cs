using System.ComponentModel.DataAnnotations;

namespace E_film_ticket.Models
{
	public class Actor
	{
        [Key]
        public int Aid { get; set; }
        [Display(Name = "Profile picture url")]
        [Required(ErrorMessage="The picture is Requered")]
        public string  pictureYRL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Full Name is requered")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="The name must be b/n 50 and 3 chars")]
        public String  FullName { get; set; }
        [Display(Name = "Boigraphy")]
        [Required(ErrorMessage ="The biography must be added")]
        public String Bio { get; set; }
        public List<ActorMovie>  Actors_Movies { get; set; }

    }

}


