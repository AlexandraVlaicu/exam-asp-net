using System;
using ex.Models;
using Microsoft.AspNetCore.Mvc;

namespace ex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly IActorRepository _actorRepository;
        private readonly IFilmRepository _filmRepository;

        public ActorsController(IActorRepository actorRepository, IFilmRepository filmRepository)
        {
            _actorRepository = actorRepository;
            _filmRepository = filmRepository;
        }

        // pentru toti actorii
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor>>> GetActors()
        {
            var actors = await _actorRepository.GetAllActorsAsync();
            return Ok(actors);
        }

        // penter actorii in functie de filmele jucate
        [HttpGet("by-movie/{movieId}")]
        public async Task<ActionResult<IEnumerable<Actor>>> GetActorsByFilm(int filmId)
        {
            var actors = await _actorRepository.GetActorsByFilmAsync(filmId);
            return Ok(actors);
        }

        // pentru informatii despre un actor cu id
        [HttpGet("{id}")]
        public async Task<ActionResult<Actor>> GetActor(int id)
        {
            var actor = await _actorRepository.GetActorByIdAsync(id);

            if (actor == null)
            {
                return NotFound();
            }

            return actor;
        }


        // pentru a asigna un film unui actor
        [HttpPost("{actorId}/assign-movie/{movieId}")]
        public async Task<IActionResult> AssignFilmtoActor(int actorId, int filmId)
        {
            var actor = await _actorRepository.GetActorByIdAsync(actorId);
            if (actor == null)
            {
                return NotFound("Actorul nu a fost gasit.");
            }

            var movie = await _filmRepository.GetFilmByIdAsync(filmId);
            if (movie == null)
            {
                return NotFound("Filmul nu a fost gasit.");
            }

            // pentree a assigna un actor la film
            await _actorRepository.AssignFilmToActorAsync(actorId, filmId);

            return Ok($"Filmul '{movie.Denumire}' a fost asignat actorului '{actor.Nume}'.");
        }
    }

}

