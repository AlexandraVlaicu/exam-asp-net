using System;
namespace ex.Models
{

    public interface IFilmRepository
    {
        Task<IEnumerable<Film>> GetAllFilmsAsync();
        Task<Film> GetFilmByIdAsync(int id);
    }

}


