import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registerMode:boolean=false;

  constructor(private httpClient:HttpClient) { }

  ngOnInit() {
    
  }
  RegisterToggle(){
    //if(this.registerMode)
      this.registerMode=!this.registerMode;
  }
  CancelToggle(registerMode:boolean) {
    this.registerMode=registerMode;
  }
  

}