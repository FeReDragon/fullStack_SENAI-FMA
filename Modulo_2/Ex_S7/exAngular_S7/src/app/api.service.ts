import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private apiUrl = 'https://64d48e0f-6f35-40e1-a3a7-ee489030ebdb.mock.pstmn.io';

  constructor(private http: HttpClient) {}

  get(path: string): Observable<any> {
    const url = `${this.apiUrl}/${path}`;
    return this.http.get<any>(url);
  }

  getFilmes(): Observable<any[]> {
    return this.get('filmes/get-all');
  }

  getAvaliacoesProntas(): Observable<any[]> {
    return this.get('avaliacoes-prontas');
  }
}

