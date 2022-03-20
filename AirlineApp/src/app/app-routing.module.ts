<<<<<<< Updated upstream
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
=======
import { NgModule } from '@angular/core';    
import { Routes, RouterModule } from '@angular/router';    
import { DashboardComponent } from './dashboard/dashboard.component';    
import { LoginComponent } from './login/login.component';    
import { RegisterComponent } from './register/register.component';    
    
    
export const routes: Routes = [    
  {    
    path: '',    
    redirectTo: 'login',    
    pathMatch: 'full',    
  },    
  {    
    path: 'login',    
    component: LoginComponent,    
    data: {    
      title: 'Login Page'    
    }    
  },    
  {    
    path: 'Dasboard',    
    component: DashboardComponent,    
    data: {    
      title: 'Dashboard Page'    
    }    
  },    
  {    
    path: 'AddUser',    
    component: RegisterComponent,    
    data: {    
      title: 'Add User Page'    
    }    
  },    
];    
    
@NgModule({    
  imports: [RouterModule.forRoot(routes)],    
  exports: [RouterModule]    
})    
export class AppRoutingModule { } 
>>>>>>> Stashed changes
