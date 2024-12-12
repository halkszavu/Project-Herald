import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { CONCERTS } from '../../app/components/model/concert-list';
import { Concert } from '../components/model/concert.model';

@Injectable({
  providedIn: 'root'
})
export class ConcertService {
  constructor() { }

  getConcert(id: string): Observable<Concert> {
    return of(CONCERTS.filter((t) => t.id === id)[0]);
  }
}
