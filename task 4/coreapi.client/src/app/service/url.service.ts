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

  postCategory(data: any) {
    return this._http.post("https://localhost:7177/api/Category/postCategory", data);
  }

  putCategory(id: any, data: any) {
    return this._http.put(`https://localhost:7177/api/Category/updateCategory/${id}`, data);
  }

  deleteCategory(id: any) {
    return this._http.delete(`https://localhost:7177/api/Category/deleteCategory?id=${id}`)

  }
}
