using System;
namespace ex.Models
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class FilmService : IFilmService
    {
        private readonly IFilmRepository _filmRepository;

        public FilmService(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }

        public async Task<IEnumerable<Film>> GetAllFilmsAsync()
        {
            return await _filmRepository.GetAllFilmsAsync();
        }

        public async Task<Film> GetFilmByIdAsync(int id)
        {
            return await _filmRepository.GetFilmByIdAsync(id);
        }
    }


}

