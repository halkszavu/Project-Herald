import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, of, tap } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  isLoggedIn = false;
  user : string | null = null;

  constructor(private router:Router) { }

  login(username : string, password : string) : Observable<boolean> {
    return of(true).pipe(
      
      tap(()=>{
        this.isLoggedIn = true;
        this.user = username;
      })
    );
  }

  logout(): void{
    this.isLoggedIn = false;
  }
}
