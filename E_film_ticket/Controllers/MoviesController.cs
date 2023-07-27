using E_film_ticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Runtime.CompilerServices;

namespace E_film_ticket.Controllers
{
	public class MoviesController : Controller
	{
		private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
			_context = context;
        }
        public async Task<IActionResult> Index()
		{
			var AllMovies =await _context.Movies.Include(n => n.Cinema).ToListAsync();
			return View(AllMovies);
		}
	}
}
