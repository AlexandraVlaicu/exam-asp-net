import { Component, OnInit } from '@angular/core';
import { Film } from './film.model';
import { FilmService } from './film.service';

@Component({
  selector: 'app-films',
  templateUrl: './films.component.css',
  styleUrls: ['./films.component.css']
})
export class FilmListComponent implements OnInit {
  films: Film[] = [];

  constructor(private filmService: FilmService) { }

  ngOnInit(): void {
    this.getFilms();
  }

  getFilms(): void {
    this.filmService.getFilms()
      .subscribe(films => this.films = films);
  }
}
