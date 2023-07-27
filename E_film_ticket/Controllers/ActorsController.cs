using E_film_ticket.Data;
using E_film_ticket.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_film_ticket.Controllers
{
	public class ActorsController : Controller
	{
		private readonly IActorServices _services;
        public ActorsController(IActorServices services)
        {
			_services = services;
        }
        public IActionResult Index()
		{
			var AllData = _services.GetAll();
			return View(AllData);
	 	}
		public IActionResult Create()
		{
			return View();
		}
	}
}
