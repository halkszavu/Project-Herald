import { Component, Input } from '@angular/core';
import { Concert } from '../model/concert.model';
import { Piece } from '../model/piece.model';
import { NgForm } from '@angular/forms';
import { ConcertService } from '../../services/concert-service.service';

@Component({
  selector: 'app-new-piece-form',
  templateUrl: './new-piece-form.component.html',
  styleUrl: './new-piece-form.component.css'
})
export class NewPieceFormComponent {
  @Input("concert") concert : Concert | undefined;

  constructor(private concertService: ConcertService) { }

  onSubmit(pieceForm: NgForm){
    console.log('Form submitted');
    console.log(pieceForm.value);

    let piece = new Piece(pieceForm.value.title, pieceForm.value.composer);

    if(this.concert){
      this.concert.programme.push(piece);
      this.concertService.updateConcert(this.concert).subscribe(
        response => {
          if(response.ok){
            console.log('Piece added');
            pieceForm.reset();
          }
        }
      )
    }
  }
}
