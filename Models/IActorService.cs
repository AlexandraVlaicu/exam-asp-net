using System;
namespace ex.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


public interface IActorService
{
    Task<IEnumerable<Actor>> GetAllActorsAsync();
    Task<IEnumerable<Actor>> GetActorsByFilmAsync(int filmId);
    Task<Actor> GetActorByIdAsync(int id);
    Task AssignFilmToActorAsync(int actorId, int filmId);
}


