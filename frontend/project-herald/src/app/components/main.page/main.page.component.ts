import { Component } from '@angular/core';
import { CONCERTS } from '../model/concert-list';
import { ConcertWidgetComponent } from '../concert.widget/concert.widget.component';
import { SidebarComponent } from "../sidebar/sidebar.component";
import { NavigationComponent } from "../navigation/navigation.component";

@Component({
  selector: 'app-herald',
  standalone: true,
  imports: [ConcertWidgetComponent, SidebarComponent, NavigationComponent],
  templateUrl: './main.page.component.html',
  styleUrl: './main.page.component.css'
})
export class MainPageComponent {
  concerts = CONCERTS;
}
