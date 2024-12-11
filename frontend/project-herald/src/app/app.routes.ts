import { Routes } from '@angular/router';
import { MainPageComponent } from './components/main.page/main.page.component';
import { LoginFormComponent } from './components/login-form/login-form.component';

export const routes: Routes = [
    { path: 'main', component: MainPageComponent},
    { path: 'login', component: LoginFormComponent},
];
