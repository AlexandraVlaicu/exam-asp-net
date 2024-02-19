using System;
namespace ex.Models
{
	public class Actor
	{
		public int ActorID { get; set; }
		public string Nume { get; set; }
		public int Varsta { get; set; }
		public List<ActorFilm> ActorFilme = new List<ActorFilm>();
    }
}

