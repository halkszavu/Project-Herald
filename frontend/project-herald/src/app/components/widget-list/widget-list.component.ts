import { Component } from '@angular/core';
import { ConcertWidgetComponent } from "../concert.widget/concert.widget.component";
import { CONCERTS } from '../model/concert-list';

@Component({
  selector: 'app-widget-list',
  standalone: true,
  imports: [ConcertWidgetComponent],
  templateUrl: './widget-list.component.html',
  styleUrl: './widget-list.component.css'
})
export class WidgetListComponent {
  concerts = CONCERTS;
}
