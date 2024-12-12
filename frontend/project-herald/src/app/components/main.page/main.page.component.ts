import { Component } from '@angular/core';
import { SidebarComponent } from "../sidebar/sidebar.component";
import { RouterOutlet } from '@angular/router';
import { ConcertDetailsModule } from '../../concert-details-module';
import { LoginModule } from '../../login-module';

@Component({
  selector: 'app-herald',
  standalone: true,
  imports: [SidebarComponent, RouterOutlet, ConcertDetailsModule, LoginModule],
  templateUrl: './main.page.component.html',
  styleUrl: './main.page.component.css'
})
export class MainPageComponent {
  
}
