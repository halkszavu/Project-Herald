import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of, tap } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  isLoggedIn = false;
  user : string | null = null;
  private loginUrl = "api/Login";

  constructor(private http: HttpClient) { }

  login(username : string, password : string) : Observable<boolean> {
    const payload = { username, password };

    return this.http.post<boolean>(this.loginUrl, payload).pipe(
      tap((response) => {
        if (response) {
          this.isLoggedIn = true;
          this.user = username;
        }
      })
    );
  }

  logout(): void{
    this.isLoggedIn = false;
  }
}
