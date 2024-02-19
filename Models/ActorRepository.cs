using System;
using Microsoft.EntityFrameworkCore;
using ex.Data;
namespace ex.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;


public class ActorRepository : IActorRepository
{
    private readonly ApplicationDbContext _context;

    public ActorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Actor>> GetAllActorsAsync()
    {
        return await _context.Actori.ToListAsync();
    }

    public async Task<IEnumerable<Actor>> GetActorsByFilmAsync(int filmId)
    {
        return await _context.Actori
            .Where(a => a.ActorFilme.Any(af => af.FilmeID == filmId))
            .ToListAsync();
    }

    public async Task<Actor> GetActorByIdAsync(int id)
    {
        return await _context.Actori.FindAsync(id);
    }

    public async Task AssignFilmToActorAsync(int actorId, int filmId)
    {
        var actorFilm = new ActorFilm { ActoriId = actorId, FilmeID = filmId };
        _context.ActorFilme.Add(actorFilm);
        await _context.SaveChangesAsync();
    }
}





