import { Component } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login-form',
  standalone: true,
  imports: [],
  templateUrl: './login-form.component.html',
  styleUrl: './login-form.component.css'
})
export class LoginFormComponent {
  constructor(public authService: AuthService, public router: Router)  {}

  login() {
    this.authService.login().subscribe(() => {
      if(this.authService.isLoggedIn){
        const redirectUrl = '/main';
        this.router.navigate([redirectUrl]);
      }
    })
  }

  logout() {
    this.authService.logout();
  }
}
