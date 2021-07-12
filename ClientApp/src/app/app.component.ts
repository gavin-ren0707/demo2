import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  public data: any;
  public title : any[]=['Home111111','Service222222','Features','Testimonial','Contact'];
  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.http.get('/api/spots').subscribe((value: any) => {
      this.data = value;
    });
  }
}
