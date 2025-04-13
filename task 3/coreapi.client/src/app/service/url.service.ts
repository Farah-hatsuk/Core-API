import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UrlService {

  constructor(private _http: HttpClient) { }

  getCategory() {
    return this._http.get("https://localhost:7177/api/Category/getCategory");
  }
}
