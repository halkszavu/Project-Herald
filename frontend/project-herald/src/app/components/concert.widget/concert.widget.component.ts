import { Component, EventEmitter, Input, output, Output } from '@angular/core';
import { Concert } from '../model/concert.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-concert-widget',
  standalone: true,
  imports: [],
  templateUrl: './concert.widget.component.html',
  styleUrl: './concert.widget.component.css'
})
export class ConcertWidgetComponent {
  @Input() concert: Concert | undefined;
  @Output() concertClick = new EventEmitter<Concert>();

  constructor(private router: Router) {}

  onConcertClick() {
    if(this.concert){
      this.concertClick.emit(this.concert);
      this.router.navigate(['/concert', this.concert.id]);
    }
  }
}
