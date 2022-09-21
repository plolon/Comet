import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class MakeService {
  constructor(private http: HttpClient) {}

  getMakes() {
    return this.http.get('https://localhost:7151/api/makes');
  }
}
