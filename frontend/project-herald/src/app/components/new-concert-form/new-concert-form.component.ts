import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-new-concert-form',
  templateUrl: './new-concert-form.component.html',
  styleUrl: './new-concert-form.component.css'
})
export class NewConcertFormComponent {

  constructor(private http : HttpClient) { }

  submit(form: NgForm){
    
  }
}
