export class Piece {
    constructor(
        public title: string,
        public composer: string,
        public id: string = ''

    ){
        if(id === ''){
            this.id = this.createId();
        }
    }

    createId(): string {
        return `${this.composer}_${this.title}`;
    }
}