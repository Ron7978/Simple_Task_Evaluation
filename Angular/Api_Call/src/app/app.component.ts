import { Component } from '@angular/core';
import { UserDataService } from './services/user-data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Api_Call';

  userData:any=[{}];

  constructor(private userdataService:UserDataService){
    this.userdataService.Users().subscribe(data=>{
      this.userData=data;
    })
  }
}
