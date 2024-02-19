using System;
namespace ex.Models
{
	public class Film
	{
        public int FilmID { get; set; }
        public string Denumire { get; set; }
        public int Durata { get; set; }
        public List<ActorFilm> ActorFilme = new List<ActorFilm>();
    }
}

