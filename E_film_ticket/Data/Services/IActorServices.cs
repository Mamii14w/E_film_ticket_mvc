using E_film_ticket.Models;

namespace E_film_ticket.Data.Services
{
    public interface IActorServices
    {
       Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor NewActor);
        Task DeleteAsync(int id);
    }
}
