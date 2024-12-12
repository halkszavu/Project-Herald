import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { CommonModule } from "@angular/common";
import { NewConcertFormComponent } from "./components/new-concert-form/new-concert-form.component";
import { RouterModule, Routes } from "@angular/router";

const routes: Routes = [
    { path: '', component: NewConcertFormComponent }
]

@NgModule({
    declarations: [
        NewConcertFormComponent
    ],
    imports: [
        FormsModule,
        CommonModule,
        RouterModule.forChild(routes)
    ],
})

export class NewConcertModule {}