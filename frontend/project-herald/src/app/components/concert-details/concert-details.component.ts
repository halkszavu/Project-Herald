import { Component } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { Location } from '@angular/common';
import { Concert } from '../model/concert.model';

@Component({
  selector: 'app-concert-details',
  standalone: true,
  imports: [],
  templateUrl: './concert-details.component.html',
  styleUrl: './concert-details.component.css'
})
export class ConcertDetailsComponent {

  constructor(
    private route: ActivatedRoute,
    private location: Location,
    private concert: Concert,
  ) { }

  ngOnInit() {
    this.initConcert();
  }

  initConcert() {
    const id = Number(this.route.snapshot.paramMap.get('id'));

  }
}
