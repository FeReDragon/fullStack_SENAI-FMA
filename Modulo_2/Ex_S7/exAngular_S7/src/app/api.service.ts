// Corrected api.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private apiUrl = 'http://localhost:3000'; 

  constructor(private http: HttpClient) {}

  get(path: string): Observable<any> {
    const url = `${this.apiUrl}/${path}`;
    return this.http.get<any>(url);
  }

  getFilmes(): Observable<any[]> {
    return this.get('avalicao-filmes');
  }

  getAvaliacoesProntas(): Observable<any[]> {
    return this.get('avalicao-filmes');
  }
}
