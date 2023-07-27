using E_film_ticket.Data.Enums;
//using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_film_ticket.Models
{
    public class MovieModel
    {
        [Key]
        public int Mid { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Double price { get; set; }

        public String Image { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
        public MovieCtacory MovieCatagory { get; set; }

        public List<ActorMovie> Actor_Movie { get; set; }

        //relations with cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

            //relations with producers
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }
}
