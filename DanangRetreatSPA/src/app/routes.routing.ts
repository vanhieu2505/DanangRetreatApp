import { Routes, RouterModule } from '@angular/router';
import { AccommodationLandingComponent } from './accommodation/accommodation-landing/accommodation-landing.component';
import { HomeComponent } from './Home/Home.component';

const routes: Routes = [
  { path: 'accommodation', component: AccommodationLandingComponent },
  { path: '**', component: HomeComponent }
];

export const RoutesRoutes = RouterModule.forRoot(routes, { enableTracing: true });
