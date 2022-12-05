import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})

export class UserDataService {

  url = "https://reqres.in/api/users";

  constructor(private http:HttpClient) { }

  Users(){
        
    return this.http.get(this.url);
  }
  
}
