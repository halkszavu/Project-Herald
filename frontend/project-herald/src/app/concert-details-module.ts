import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { NewPieceFormComponent } from "./components/new-piece-form/new-piece-form.component";
import { ConcertDetailsComponent } from "./components/concert-details/concert-details.component";
import { CommonModule } from "@angular/common";

@NgModule({
    declarations: [
        NewPieceFormComponent,
        ConcertDetailsComponent,
    ],
    imports: [
        FormsModule,
        CommonModule,
    ],
})

export class ConcertDetailsModule {}