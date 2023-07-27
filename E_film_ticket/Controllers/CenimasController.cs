using E_film_ticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_film_ticket.Controllers
{
	public class CenimasController : Controller
	{
		private readonly AppDbContext _context;
        public CenimasController(AppDbContext context)
        {
			_context = context; 
        }
        public async Task<IActionResult> Index()
		{
			var AllCenimas = await _context.cinemas.ToListAsync();
			return View(AllCenimas);
		}
	}
}
