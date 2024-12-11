import { Component } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { Location } from '@angular/common';
import { Concert } from '../model/concert.model';
import { ConcertService } from '../../services/concert-service.service';

@Component({
  selector: 'app-concert-details',
  standalone: true,
  imports: [],
  templateUrl: './concert-details.component.html',
  styleUrl: './concert-details.component.css'
})
export class ConcertDetailsComponent {
  concert: Concert | undefined;

  constructor(
    private route: ActivatedRoute,
    private concertService: ConcertService,
  ) { }

  ngOnInit() {
    this.initConcert();
  }

  initConcert() {
    const id = this.route.snapshot.paramMap.get('id');
    if (id) {
      this.concertService.getConcert(id).subscribe(concert => {
        this.concert = concert;
        console.log(this.concert?.id);
      });
    } else {
      // handle the case when id is null
      console.error('Concert ID is null');
    }
  }
}