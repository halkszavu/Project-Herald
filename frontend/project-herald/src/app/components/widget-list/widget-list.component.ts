import { Component } from '@angular/core';
import { ConcertWidgetComponent } from "../concert.widget/concert.widget.component";
import { CONCERTS } from '../model/concert-list';
import { Concert } from '../model/concert.model';
import { ConcertService } from '../../services/concert-service.service';

@Component({
  selector: 'app-widget-list',
  standalone: true,
  imports: [ConcertWidgetComponent],
  templateUrl: './widget-list.component.html',
  styleUrl: './widget-list.component.css'
})
export class WidgetListComponent {
  concerts: Concert[] = [];

  constructor(private concertService : ConcertService) {}

  ngOnInit() {
    this.initConcerts();
  }

  initConcerts() {
    this.concertService.getConcerts().subscribe(concerts => {
      this.concerts = concerts;
    });
  }
}
