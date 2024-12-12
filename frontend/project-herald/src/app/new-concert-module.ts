import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { CommonModule } from "@angular/common";
import { NewConcertFormComponent } from "./components/new-concert-form/new-concert-form.component";

@NgModule({
    declarations: [
        NewConcertFormComponent
    ],
    imports: [
        FormsModule,
        CommonModule,
    ],
})

export class NewConcertModule {}