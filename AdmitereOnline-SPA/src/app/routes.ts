import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { UniversitateComponent } from './universitate/universitate.component';
import { AdmitereComponent } from './admitere/admitere.component';
import { MessagesComponent } from './messages/messages.component';
import { FacultatiComponent } from './facultati/facultati.component';
import { ReglementariComponent } from './reglementari/reglementari.component';
import { AuthGuard } from './_guards/auth.guard';


export const appRoutes: Routes = [
     { path: 'home', component: HomeComponent},   
     { path: 'universitate', component: UniversitateComponent},
     { path: 'facultati', component: FacultatiComponent},
     { path: 'admitere', component: AdmitereComponent, canActivate: [AuthGuard]},
     { path: 'reglementari', component: ReglementariComponent},
     { path: 'messages', component: MessagesComponent},
     { path: '**', redirectTo: 'home', pathMatch: 'full' },
];

