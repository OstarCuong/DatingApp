import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The Dating app';
  users : any;

  constructor(private http: HttpClient){}


  ngOnInit(){
    this.getUsers();
    
  }

  getUsers(){
    this.http.get('http://localhost:5263/api/users').subscribe(Response => {
      this.users = Response;
    }, error => {
      console.log(error);
    })
  }
}
