import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import{Observable, observable} from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl="http://localhost:5000/api"
  constructor(private http:HttpClient) { }
  getFlightList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/flightDetails');
  }
  addflight(val:any){
    return this.http.post(this.APIUrl+'/FlightDetails',val)
  }
  updateFlight(val:any){
    return this.http.post(this.APIUrl+'/FlightDetails',val)
  }
  deleteFlight(val:any){
    return this.http.post(this.APIUrl+'/FlightDetails',val)
  }
  //user datails
  getUserList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/UserDetails');
  }
  adduser(val:any){
    return this.http.post(this.APIUrl+'/UserDetails',val)
  }
  updateUser(val:any){
    return this.http.post(this.APIUrl+'/UserDetails',val)
  }
  deleteuser(val:any){
    return this.http.post(this.APIUrl+'/UserDetails',val)
  }
  //acconttype
  getAccountList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/AccountType');
  }
  addAccontType(val:any){
    return this.http.post(this.APIUrl+'/AccountType',val)
  }
 
  //getalldatails
  getAlluserName():Observable<any[]>{
    return this.http.get<any[]>(this.APIUrl+'/FlightDetails/GetAllUserDatails');
  }
}
