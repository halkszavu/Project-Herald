import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
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

  addConcert(concert: Concert){
    return this.http.post<Concert>(this.concertsUrl, concert);
  }

  updateConcert(concert: Concert){
    return this.http.put<Concert>(this.concertsUrl, concert, {observe: 'response'});
  }
}
