import { Component } from '@angular/core';
import { SidebarComponent } from "../sidebar/sidebar.component";
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-herald',
  standalone: true,
  imports: [SidebarComponent, RouterOutlet],
  templateUrl: './main.page.component.html',
  styleUrl: './main.page.component.css'
})
export class MainPageComponent {
  
}
