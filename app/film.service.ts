import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Film } from './film.model';

@Injectable({
  providedIn: 'root'
})
export class FilmService {
  private apiUrl = 'api/localhost:7021/api/Films';

  constructor(private http: HttpClient) { }

  getFilms(): Observable<Film[]> {
    return this.http.get<Film[]>(this.apiUrl);
  }
}
