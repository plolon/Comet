import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FeatureService {

  constructor(private http: HttpClient) {}

  getFeatures() {
    return this.http.get('https://localhost:7151/api/features');
  }
}
