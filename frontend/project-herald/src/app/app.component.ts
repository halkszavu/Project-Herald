import { Component } from '@angular/core';
import { MainPageComponent } from './components/main.page/main.page.component';
import { AuthService } from './services/auth.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ MainPageComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Concerts';

  constructor(public authService : AuthService) {}
}
