using System;
using ex.Models;

namespace ex.Models
{


    public interface IActorRepository
    {
        Task<IEnumerable<Actor>> GetAllActorsAsync();
        Task<IEnumerable<Actor>> GetActorsByFilmAsync(int filmId);
        Task<Actor> GetActorByIdAsync(int id);
        Task AssignFilmToActorAsync(int actorId, int filmId);
    }

}


