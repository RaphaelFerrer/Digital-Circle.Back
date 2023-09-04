import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class EntidadeService {
  constructor(private httpClient: HttpClient) {}

  public getAll(): Observable<any> {
    return this.httpClient.get<any>('https://localhost:7033/Entidade/tb01');
  }

  excluirRegistro(id: string): Observable<any> {
    const url = `https://localhost:7033/Entidade/tb01/delete`;
    return this.httpClient.post(url, {
      id,
    });
  }

  incluirRegistro(texto: string): Observable<any> {
    return this.httpClient.post(
      `https://localhost:7033/Entidade/tb01/create?texto=${texto}`,
      null
    );
  }

  atualizarRegistro(registro: any): Observable<any> {
    return this.httpClient.put(
      `https://localhost:7033/Entidade/tb01/update`,
      registro
    );
  }
}
