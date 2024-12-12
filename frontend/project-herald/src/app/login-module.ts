import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { NewPieceFormComponent } from "./components/new-piece-form/new-piece-form.component";
import { ConcertDetailsComponent } from "./components/concert-details/concert-details.component";
import { CommonModule } from "@angular/common";
import { LoginFormComponent } from "./components/login-form/login-form.component";

@NgModule({
    declarations: [
        LoginFormComponent
    ],
    imports: [
        FormsModule,
        CommonModule,
    ],
})

export class LoginModule {}