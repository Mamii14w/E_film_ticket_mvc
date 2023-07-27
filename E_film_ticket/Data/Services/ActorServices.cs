using E_film_ticket.Models;

namespace E_film_ticket.Data.Services
{
    public class ActorServices : IActorServices
    {
        private readonly AppDbContext _context;
        public ActorServices(AppDbContext context)
        {
            _context = context;   
        }
        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public Actor Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> GetAll()
        {var val = _context.Actors.ToList();
            return val;
        }

        public Actor GetById(int id)
        {
            
           
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}

