import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../components/home/home';

@Injectable({
  providedIn: 'root',
})
export class Api {
  endpointUrl: string = 'https://localhost:7084/api/CategoryApi';
  //c# 
  //int a = 10;
  //ts
  //a:int = 10
  //HttpClient httpClient
  constructor(private httpClient: HttpClient) {
  }
  // public void getCategories(){

  // }
  getCategories(): Observable<Category[]> {
    return this.httpClient.get<Category[]>(`${this.endpointUrl}/Categories`);
  }
  deleteCategory(id: number): Observable<void> {
    return this.httpClient.post<void>(`${this.endpointUrl}/delete/${id}`, {});
  }
}