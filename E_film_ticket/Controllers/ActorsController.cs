using E_film_ticket.Data;
using E_film_ticket.Data.Services;
using E_film_ticket.Models;
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
        public async Task<IActionResult> Index()
		{
			var AllData =await _services.GetAllAsync();
			return View(AllData);
	 	}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(Actor actor)
		{
			if (!ModelState.IsValid)
			{
				return View(actor);
			}
		   await
				_services.AddAsync(actor);
			return RedirectToAction(nameof(Index));
		}
	   public async Task<IActionResult> Details(int id)
		{
			var Gid =await _services.GetByIdAsync(id);

			if (Gid == null) { 
				return View("Not Found");
			}
			return View(Gid);
		}

		public async Task<IActionResult> Edit(int id)
		{
			var ActorId = await _services.GetByIdAsync(id);

			if (ActorId == null) { 
				return View("Not Found"); 
			}
		    return View(ActorId);
		}
	[HttpPost, ActionName("Edit")]
      public async Task<IActionResult> Edit(int id, [Bind("Aid,FullName,pictureYRL,Bio")]Actor actor)
		{

            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _services.UpdateAsync(id,actor);
            return RedirectToAction(nameof(Index));
        }
		public async Task<IActionResult> Delete(int id)
		{
			var ActorId = await _services.GetByIdAsync(id);
			if (ActorId == null)
			{
				return View("Not Found");
			}
			return View(ActorId);
		}
		[HttpPost,ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var ActorId = await _services.GetByIdAsync(id);
			if (ActorId == null) { return View("Not Found"); }
		await	_services.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
