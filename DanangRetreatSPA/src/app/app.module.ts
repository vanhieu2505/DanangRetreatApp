import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { FooterComponent } from './footer/footer.component';
import { AccommodationCardComponent } from './accommodation/accommodation-card/accommodation-card.component';
import { AccommodationLandingComponent } from './accommodation/accommodation-landing/accommodation-landing.component';
import { HomeComponent } from './Home/Home.component';
import { RoutesRoutes } from './routes.routing';
import { FormsModule } from '@angular/forms';

@NgModule({
   declarations: [
      AppComponent,
      NavbarComponent,
      FooterComponent,
      AccommodationCardComponent,
      AccommodationLandingComponent,
      HomeComponent
   ],
   imports: [
      BrowserModule,
      RoutesRoutes,
      FormsModule,
      BsDatepickerModule.forRoot()
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
