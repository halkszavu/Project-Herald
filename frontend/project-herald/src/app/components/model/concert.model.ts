import { Piece } from './piece.model';

export class Concert {
    constructor(
      public id:string,
      public name:string,
      public date:string,
      public programme: Piece[],
      )
    {}
  }
  