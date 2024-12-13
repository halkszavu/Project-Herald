import { Piece } from './piece.model';

export class Concert {
    constructor(
      public id:string,
      public name:string,
      public date:string,
      public programme: Piece[],
      )
    {
      if(id === ''){
        this.id = this.generateId();
      }
    }

    generateId(){
      let r = Math.floor(Math.random() * 500);
      return `${this.name}${r}`;
    }
  }
  