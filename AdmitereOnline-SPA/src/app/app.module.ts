import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule} from '@angular/common/http';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { AdmitereComponent } from './admitere/admitere.component';
import { UniversitateComponent } from './universitate/universitate.component';
import { FacultatiComponent } from './facultati/facultati.component';
import { RouterModule } from '@angular/router';
import { appRoutes } from './routes';
import { ContactComponent } from './contact/contact.component';
import { DocumenteComponent } from './documente/documente.component';
import {MatGridListModule} from '@angular/material/grid-list';
import { ViewdocsComponent } from './viewdocs/viewdocs.component';



@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      AdmitereComponent,
      UniversitateComponent,
      FacultatiComponent,
      ContactComponent,
      DocumenteComponent,
      ViewdocsComponent,
  
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      BrowserAnimationsModule,
      BsDropdownModule.forRoot(),
      RouterModule.forRoot(appRoutes),
      MatGridListModule,
      ReactiveFormsModule
   ],
   providers: [
      AuthService,
      ErrorInterceptorProvider,
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
