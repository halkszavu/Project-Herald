import { Component } from '@angular/core';
import { CONCERTS } from '../model/concert-list';
import { ConcertWidgetComponent } from '../concert.widget/concert.widget.component';

@Component({
  selector: 'app-herald',
  standalone: true,
  imports: [ConcertWidgetComponent],
  templateUrl: './main.page.component.html',
  styleUrl: './main.page.component.css'
})
export class MainPageComponent {
  concerts = CONCERTS;
}
