import { Component, Input } from '@angular/core';
import { Concert } from '../model/concert.model';

@Component({
  selector: 'app-concert-widget',
  standalone: true,
  imports: [],
  templateUrl: './concert.widget.component.html',
  styleUrl: './concert.widget.component.css'
})
export class ConcertWidgetComponent {
  constructor() {}
  @Input() concert: Concert | undefined;
}
