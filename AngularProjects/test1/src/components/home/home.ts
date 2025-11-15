import { Component, OnInit } from '@angular/core';
import { Api } from '../../services/api';

@Component({
  selector: 'app-home',
  imports: [],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home implements OnInit {
  constructor(private apiService:Api){

  }
  ngOnInit(): void {
    this.apiService.getCategories().subscribe({
      next: (response)=>{
        console.log(response);
      },
      error: (err)=>{
        console.error(err)
      }
    });
  }

}
