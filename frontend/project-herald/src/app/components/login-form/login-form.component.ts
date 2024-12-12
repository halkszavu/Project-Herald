import { Component } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrl: './login-form.component.css'
})
export class LoginFormComponent {
  constructor(public authService: AuthService, public router: Router)  {}

  login(form: NgForm) {
    if(form.valid){
      const {username, password} = form.value;
      this.authService.login(username, password).subscribe(() => {
        if(this.authService.isLoggedIn){
          const redirectUrl = '/main';
          this.router.navigate([redirectUrl]);
        }
      });
    }
  }

  logout() {
    this.authService.logout();
  }
}
