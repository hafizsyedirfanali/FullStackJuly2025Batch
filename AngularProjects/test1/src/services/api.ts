import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class Api {
  endpointUrl:string = 'http://localhost:5000/api/CategoryApi';
  //c# 
  //int a = 10;
  //ts
  //a:int = 10
  //HttpClient httpClient
  constructor(private httpClient:HttpClient){
  }
  // public void getCategories(){

  // }
  getCategories():Observable<any>{
    return this.httpClient.get<any>(`${this.endpointUrl}/Categories`);
  }
}