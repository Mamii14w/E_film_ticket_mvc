using System.ComponentModel.DataAnnotations;

namespace E_film_ticket.Models
{
	public class Cinema
	{
        [Key]
		public int Cid { get; set; }

        public String logo { get; set; }
		public String CName { get; set; }
        public String Description { get; set; }
        //relations 
        public List<MovieModel> movies { get; set; }


    }

	}
