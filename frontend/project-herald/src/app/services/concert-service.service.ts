import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { CONCERTS } from '../../app/components/model/concert-list';
import { Concert } from '../components/model/concert.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ConcertService {
  private concertsUrl = "api/Concert"

  constructor(private http: HttpClient) { }

  getConcert(id: string): Observable<Concert> {
    console.log(`${this.concertsUrl}/${id}`);
    return this.http.get<Concert>(`${this.concertsUrl}/${id}`);
  }

  getConcerts(){
    return this.http.get<Concert[]>(this.concertsUrl, {observe: 'response'});
  }
}
