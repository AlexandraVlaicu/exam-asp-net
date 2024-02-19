using System;
using Microsoft.EntityFrameworkCore;
using ex.Models;
using ex.Data;

namespace ex.Modelsusing;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class FilmRepository : IFilmRepository
{
    private readonly ApplicationDbContext _context;

    public FilmRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Film>> GetAllFilmsAsync()
    {
        return await _context.Filme.ToListAsync();
    }

    public async Task<Film> GetFilmByIdAsync(int id)
    {
        return await _context.Filme.FindAsync(id);
    }
}



