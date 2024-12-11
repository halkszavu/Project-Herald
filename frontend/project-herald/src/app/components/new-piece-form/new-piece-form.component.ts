import { Component, Input } from '@angular/core';
import { Concert } from '../model/concert.model';
import { Piece } from '../model/piece.model';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-new-piece-form',
  templateUrl: './new-piece-form.component.html',
  styleUrl: './new-piece-form.component.css'
})
export class NewPieceFormComponent {
  @Input("concert") concert : Concert | undefined;
  newPiece : Piece | undefined;

  constructor() { }

  onSubmit(pieceForm: NgForm){
    if(this.newPiece){
      console.log(this.newPiece);
    }
  }

  editPiece(piece: Piece) {
    this.newPiece = piece;
  }

  addPiece() {
    this.newPiece = new Piece('','');
  }

  deletePiece(piece: Piece) {
    this.concert?.pieces.splice(this.concert.pieces.indexOf(piece), 1);
  }

  getPieces() {
    return this.concert?.pieces;
  }
}
