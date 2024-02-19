using System;
namespace ex.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IFilmService
{
    Task<IEnumerable<Film>> GetAllFilmsAsync();
    Task<Film> GetFilmByIdAsync(int id);
}



