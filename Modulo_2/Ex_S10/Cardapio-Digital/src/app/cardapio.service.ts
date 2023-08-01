import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Comida } from '../app/shared/Interfaces/comida.interface';
import { Bebida } from '../app/shared/Interfaces/bebida.interface';

@Injectable({
  providedIn: 'root'
})
export class CardapioService {
  private apiUrl = 'http://localhost:3000'; // substitua pelo endereço da sua API

  constructor(private http: HttpClient) { }

  getComidas(): Observable<Comida[]> {
    return this.http.get<Comida[]>(`${this.apiUrl}/comidas`);
  }

  getBebidas(): Observable<Bebida[]> {
    return this.http.get<Bebida[]>(`${this.apiUrl}/bebidas`);
  }

  addComida(comida: Comida): Observable<Comida> {
    return this.http.post<Comida>(`${this.apiUrl}/comidas`, comida);
  }

  addBebida(bebida: Bebida): Observable<Bebida> {
    return this.http.post<Bebida>(`${this.apiUrl}/bebidas`, bebida);
  }

  updateComida(comida: Comida): Observable<Comida> {
    return this.http.put<Comida>(`${this.apiUrl}/comidas/${comida.id}`, comida);
  }

  updateBebida(bebida: Bebida): Observable<Bebida> {
    return this.http.put<Bebida>(`${this.apiUrl}/bebidas/${bebida.id}`, bebida);
  }

  deleteComida(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/comidas/${id}`);
  }

  deleteBebida(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/bebidas/${id}`);
  }
}
