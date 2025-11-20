import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { Api } from '../../services/api';
import { CommonModule } from '@angular/common';
export interface Category {
  id: number;
  name: string;
  description?: string | null;
  isAction: boolean;
}
@Component({
  selector: 'app-home',
  imports: [CommonModule],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home implements OnInit {
  items:Category[] = [];

  constructor(private apiService:Api, private cdr: ChangeDetectorRef){

  }
  ngOnInit(): void {
    this.apiService.getCategories().subscribe({
      next: (response:Category[])=>{
        this.items = [...response]; //spread operator
        this.cdr.detectChanges();
      },
      error: (err)=>{
        console.error(err)
      }
    });
  }

  deleteItem(id:number):void{
    this.apiService.deleteCategory(id).subscribe({
      next: ()=>{
        this.items = this.items.filter(item => item.id !== id);
        this.cdr.detectChanges();
      },
      error: (err)=>{
        console.error(err);
      }
    });
  }
}
