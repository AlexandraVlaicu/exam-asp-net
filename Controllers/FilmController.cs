using System;
using ex.Models;
using Microsoft.AspNetCore.Mvc;

namespace ex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly IFilmService _filmService;

        public FilmsController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        //  pentru toate filmele
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Film>>> GetFilms()
        {
            var films = await _filmService.GetAllFilmsAsync();
            return Ok(films);
        }

        // pentru informatii despre un film cu un id
        [HttpGet("{id}")]
        public async Task<ActionResult<Film>> GetFilm(int id)
        {
            var film = await _filmService.GetFilmByIdAsync(id);

            if (film == null)
            {
                return NotFound();
            }

            return film;
        }
    }

}

