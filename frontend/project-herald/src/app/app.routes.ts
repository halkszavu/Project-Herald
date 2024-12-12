import { Routes } from '@angular/router';
import { LoginFormComponent } from './components/login-form/login-form.component';
import { WidgetListComponent } from './components/widget-list/widget-list.component';
import { ConcertDetailsComponent } from './components/concert-details/concert-details.component';
import { NewConcertFormComponent } from './components/new-concert-form/new-concert-form.component';

export const routes: Routes = [
    { path: 'main', component: WidgetListComponent},
    { path: 'login', component: LoginFormComponent},
    { path: 'newConcert', 
        loadChildren: () => import('./new-concert-module').then(m => m.NewConcertModule)
     },
    { path: 'concert/:id', component: ConcertDetailsComponent },
];
