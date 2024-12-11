import { Concert } from "./concert.model";
import { Piece } from "./piece.model";


export const CONCERTS: Concert[] = [
    new Concert('1', 'Karácsonyi koncert', '2024-12-16', [
        new Piece('Academic ouverture', 'Johannes Brahms'),
        new Piece('Auf einem Ball-polka', 'Nagy Zsombor'),
        new Piece('Enigma Variations: Nimrod', 'Edward Elgar'),
        new Piece('Pomp and Circumstance March No. 1', 'Edward Elgar'),
        new Piece('Karácsonyi kantáta', 'Tóth Péter'),
        new Piece('Sleeping Beauty Waltz', 'Pjotr Iljics Csajkovszkij'),
        new Piece('Swan Lake Suite', 'Pjotr Iljics Csajkovszkij'),
        new Piece('The Nutcracker Suite', 'Pjotr Iljics Csajkovszkij'),
    ]),
    new Concert('2', 'Tavaszi koncert', '2025-04-02', []),
    new Concert('3', 'Fonyódi koncert 1', '2025-07-27', []),
    new Concert('4', 'Fonyódi koncert 2', '2025-07-28', []),
    new Concert('5', 'Fonyódi koncert 3', '2025-07-29', []),
    new Concert('6', 'Fonyódi koncert 4', '2025-07-30', []),
    new Concert('7', 'Fonyódi koncert 5', '2025-07-31', []),
    new Concert('8', 'Fonyódi koncert 6', '2025-08-01', []),
    new Concert('9', 'Fonyódi koncert 7', '2025-08-02', []),
    new Concert('10', 'Fonyódi koncert 8', '2025-08-03', []),
    new Concert('11', 'Fonyódi koncert 9', '2025-08-04', []),
    new Concert('12', 'Fonyódi koncert 10', '2025-08-05', []),
    new Concert('13', 'Fonyódi koncert 11', '2025-08-06', []),
];