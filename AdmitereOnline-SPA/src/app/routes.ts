import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { UniversitateComponent } from './universitate/universitate.component';
import { AdmitereComponent } from './admitere/admitere.component';
import { FacultatiComponent } from './facultati/facultati.component';
import { AuthGuard } from './_guards/auth.guard';
import { ContactComponent} from './contact/contact.component';
import { ExamComponent } from './exam/exam.component';
import { RezultateComponent } from './rezultate/rezultate.component';
import { DocumenteComponent} from './documente/documente.component';
import { ProfileComponent } from './profile/profile.component';
import { ViewdocsComponent} from './viewdocs/viewdocs.component';



export const appRoutes: Routes = [
     { path: 'home', component: HomeComponent},
     { path: 'universitate', component: UniversitateComponent},
     { path: 'facultati', component: FacultatiComponent},
     
     { path: 'admitere', component: AdmitereComponent, canActivate: [AuthGuard]},
     { path: 'contact', component: ContactComponent},
     { path: 'exam', component: ExamComponent},
     { path: 'rezultate', component : RezultateComponent},
     { path: 'documente', component: DocumenteComponent, canActivate: [AuthGuard]},
     { path: 'profile', component: ProfileComponent},
     { path: 'viewdocs',component: ViewdocsComponent, canActivate: [AuthGuard]},
     {path: '**', redirectTo: 'home', pathMatch: 'full'},

];

