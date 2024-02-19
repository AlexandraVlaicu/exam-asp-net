import { Component, OnInit } from '@angular/core';
import { Actor } from './actor.model';
import { Film } from './film.model';
import { ActorService } from './actor.service';
import { FilmService } from './film.service';

@Component({
  selector: 'app-assign-film',
  templateUrl: './assign-film.component.css',
  styleUrls: ['./assign-film.component.css']
})
export class AssignMovieComponent implements OnInit {
  actors: Actor[] = [];
  films: Film[] = [];
  selectedActorId: number = 0;
  selectedFilmId: number = 0;

  constructor(private actorService: ActorService, private filmService: FilmService) { }

  ngOnInit(): void {
    this.getActors();
    this.getFilms();
  }

  getActors(): void {
    this.actorService.getActors()
      .subscribe(actors => this.actors = actors);
  }

  getFilms(): void {
    this.filmService.getFilms()
      .subscribe(films => this.films = films);
  }

  assignMovie(): void {
    if (this.selectedActorId && this.selectedFilmId) {
      // Trimiteți cererea către backend pentru asignare
    }
  }
}
