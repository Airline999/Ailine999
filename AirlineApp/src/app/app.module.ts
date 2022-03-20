import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
<<<<<<< Updated upstream
import { FlightDetailsComponent } from './flight-details/flight-details.component';
import { AddFlightComponent } from './flight-details/add-flight/add-flight.component';
import { DeleteFlightComponent } from './flight-details/delete-flight/delete-flight.component';
import { UserDetailsComponent } from './user-details/user-details.component';
import { AddUserComponent } from './user-details/add-user/add-user.component';
import { DeleteUserComponent } from './user-details/delete-user/delete-user.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import{SharedService} from './shared.service';
import{HttpClientModule} from '@angular/common/http';
import{FormsModule,ReactiveFormsModule} from '@angular/forms';
import { SearchFlightComponent } from './search-flight/search-flight.component';
@NgModule({
  declarations: [
    AppComponent,
    FlightDetailsComponent,
    AddFlightComponent,
    DeleteFlightComponent,
    UserDetailsComponent,
    AddUserComponent,
    DeleteUserComponent,
    LoginComponent,
    HomeComponent,
    SearchFlightComponent
=======
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { DashboardComponent } from './dashboard/dashboard.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    DashboardComponent
>>>>>>> Stashed changes
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
