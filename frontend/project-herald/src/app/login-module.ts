import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
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