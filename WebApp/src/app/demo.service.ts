import { Injectable } from '@angular/core';
import * as configurl from '../assets/config/config.json';
import { Observable, Subject } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class DemoService {
  config = {
    ApiUrl: configurl,
  };
  constructor(private http: HttpClient) {
    console.log(this.config)
    this.getJSON().subscribe((data) => {
      this.config.ApiUrl = data.apiServer.url;
    });
  }
  public getJSON(): Observable<any> {
    return this.http.get('./assets/config/config.json');
  }
  getData(): Observable<any> {
    return this.http.get(this.config.ApiUrl + '/demo',
      { responseType: 'text' }
    );
  }
}