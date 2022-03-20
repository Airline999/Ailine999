import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import{FlightDetailsComponent} from './flight-details/flight-details.component';
import{HomeComponent} from './home/home.component';
import{LoginComponent} from './login/login.component';
import { SearchFlightComponent } from './search-flight/search-flight.component';
import{UserDetailsComponent} from './user-details/user-details.component';
const routes: Routes = [
  {path:'flightdetails',component:FlightDetailsComponent},
  {path:'userdetails',component:UserDetailsComponent},
  {path:'login',component:LoginComponent},
  {path:'home',component:HomeComponent},
  {path:'search',component:SearchFlightComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
