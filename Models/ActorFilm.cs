using System;
namespace ex.Models
{
	public class ActorFilm
	{   public int ActorFilmID { get; set; }
		public int ActoriId { get; set; }
		public int FilmeID { get; set; }
		public Actor Actor { get; set; }
		public Film Film { get; set; }
	}
}

