import { Routes } from '@angular/router';
import { LoginFormComponent } from './components/login-form/login-form.component';
import { WidgetListComponent } from './components/widget-list/widget-list.component';
import { ConcertDetailsComponent } from './components/concert-details/concert-details.component';

export const routes: Routes = [
    { path: 'main', component: WidgetListComponent},
    { path: 'login', component: LoginFormComponent},
    { path: 'concert/:id', component: ConcertDetailsComponent },
];
