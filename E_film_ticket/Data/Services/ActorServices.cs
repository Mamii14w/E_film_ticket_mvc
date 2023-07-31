using E_film_ticket.Models;
using Microsoft.EntityFrameworkCore;

namespace E_film_ticket.Data.Services
{
    public class ActorServices : IActorServices
    {
        private readonly AppDbContext _context;
        public ActorServices(AppDbContext context)
        {
            _context = context;   
        }
        public async Task  AddAsync(Actor actor)
        {
           await _context.Actors.AddAsync(actor);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Aid == id);
            _context.Actors.Remove(result);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var val =await _context.Actors.ToListAsync();
            return val;
        }

        public  async Task<Actor> GetByIdAsync(int id)
        {

            var res = await _context.Actors.FirstOrDefaultAsync(n => n.Aid == id);
            return res;
        }

        public async Task<Actor> UpdateAsync(int id, Actor actor)
        {
            _context.Update(actor);
            await _context.SaveChangesAsync();
            return actor;
        }
    }

}