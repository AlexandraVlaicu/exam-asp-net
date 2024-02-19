using System;
namespace ex.Models;
using System.Collections.Generic;
using System.Threading.Tasks;



public class ActorService : IActorService
{
    private readonly IActorRepository _actorRepository;

    public ActorService(IActorRepository actorRepository)
    {
        _actorRepository = actorRepository;
    }

    public async Task<IEnumerable<Actor>> GetAllActorsAsync()
    {
        return await _actorRepository.GetAllActorsAsync();
    }

    public async Task<IEnumerable<Actor>> GetActorsByFilmAsync(int filmId)
    {
        return await _actorRepository.GetActorsByFilmAsync(filmId);
    }

    public async Task<Actor> GetActorByIdAsync(int id)
    {
        return await _actorRepository.GetActorByIdAsync(id);
    }

    public async Task AssignFilmToActorAsync(int actorId, int filmId)
    {
        await _actorRepository.AssignFilmToActorAsync(actorId, filmId);
    }
}


