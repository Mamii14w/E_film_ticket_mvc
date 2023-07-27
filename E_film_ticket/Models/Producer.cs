using System.ComponentModel.DataAnnotations;

namespace E_film_ticket.Models
{
	public class Producer
	{
        [Key]
        public int PID { get; set; }
        [Display(Name = "Profile Picture")]
        public String ProfilePic { get; set; }
        [Display(Name ="Full Name")]
        public String  FullName { get; set; }
        [Display(Name ="Biography")]
        public String Biography { get; set; }
		//relations
		public List<MovieModel> movies { get; set; }
    }
}
