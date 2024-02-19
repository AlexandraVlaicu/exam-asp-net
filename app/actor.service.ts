import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Actor } from './actor.model';

@Injectable({
  providedIn: 'root'
})
export class ActorService {
  private apiUrl = 'api/localhost:7021/api/actors';

  constructor(private http: HttpClient) { }

  getActors(): Observable<Actor[]> {
    return this.http.get<Actor[]>(this.apiUrl);
  }
}