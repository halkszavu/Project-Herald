import { Component, EventEmitter, Input, output, Output } from '@angular/core';
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
  @Output() concertClick = new EventEmitter<Concert>();

  onConcertClick() {
    if(this.concert){
      
    }
  }
}
