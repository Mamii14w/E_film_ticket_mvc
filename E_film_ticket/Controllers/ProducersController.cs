using E_film_ticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_film_ticket.Controllers
{
	public class ProducersController : Controller
	{
		private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
			_context = context;
        }
        public async Task<IActionResult> Index()
		{
			var AllProducers = await _context.producers.ToListAsync();
			return View(AllProducers);
		}
	}
}
