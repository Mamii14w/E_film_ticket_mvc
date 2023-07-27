using E_film_ticket.Models;

namespace E_film_ticket.Data.Services
{
    public interface IActorServices
    {
        IEnumerable<Actor> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor NewActor);
        Actor Delete(int id);
    }
}
