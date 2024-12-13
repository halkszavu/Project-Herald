import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Concert } from '../model/concert.model';
import { ConcertService } from '../../services/concert-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-new-concert-form',
  templateUrl: './new-concert-form.component.html',
  styleUrl: './new-concert-form.component.css'
})
export class NewConcertFormComponent {

  constructor(private service: ConcertService, private router : Router) { }

  submit(form: NgForm){
    console.log(form.value);
    let concert = new Concert('', form.value.title, form.value.date, []);
    let result = this.service.addConcert(concert);
    result.subscribe(
      response => {
        if(response.ok){
          console.log('Concert added');
          form.reset();
          this.router.navigate(['concert/', response.body?.id]);
        }
      }
    )
  }
}
