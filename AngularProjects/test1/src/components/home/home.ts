import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { Api } from '../../services/api';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule, FormGroup, FormBuilder, Validators } from '@angular/forms';
export interface Category {
  id: number;
  name: string;
  description?: string | null;
  isAction: boolean;
}
@Component({
  selector: 'app-home',
  imports: [CommonModule, ReactiveFormsModule, FormsModule],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home implements OnInit {
  items: Category[] = [];
  isAdding: boolean = false;
  isEditing: boolean = false;
  addForm!: FormGroup;
  editForm!: FormGroup;
  constructor(private apiService: Api,
    private fb: FormBuilder,
    private cdr: ChangeDetectorRef) {

  }
  ngOnInit(): void {
    this.addForm = this.fb.group({
      name: ['', Validators.required],
      description: ['', [Validators.required, Validators.maxLength(100)]],
      isAction: [false, Validators.required],
      //studentType: ['', [Validators.required, Validators.pattern('R|E|O')]],
    });
    this.editForm = this.fb.group({
      id: ['', Validators.required],
      name: ['', Validators.required],
      description: ['', [Validators.required, Validators.maxLength(100)]],
      isAction: [false, Validators.required],
      //studentType: ['', [Validators.required, Validators.pattern('R|E|O')]],
    });


    this.apiService.getCategories().subscribe({
      next: (response: Category[]) => {
        this.items = [...response]; //spread operator
        this.cdr.detectChanges();
      },
      error: (err) => {
        console.error(err)
      }
    });
  }

  addCategory(): void {
    const payload = this.addForm.value;
    this.apiService.addCategory(payload).subscribe({
      next: (newCategory: Category) => {
        this.items.push(newCategory);
        this.isAdding = false;
        this.addForm.reset();
        this.cdr.detectChanges();
      }
      ,
      error: (err) => {
        console.error(err);
      }
    });
  }

  updateCategory():void{
    const payload = this.editForm.value;
    this.apiService.updateCategory(payload).subscribe({
      next: (updatedCategory:Category)=>{
        const index = this.items.findIndex(item => item.id === updatedCategory.id);
        if(index !== -1){
          this.items[index] = updatedCategory;
        }
        this.isEditing = false;
        this.editForm.reset();
        this.cdr.detectChanges();
      },
      error: (err)=>{
        console.error(err);
      }
    });
  } 



  editItem(id:number):void{
    this.isEditing = true;
    const item = this.items.find(i => i.id === id);
    if(item){
      this.editForm.setValue({
        id: item.id,
        name: item.name,
        description: item.description,
        isAction: item.isAction
      });
    }
  }

  deleteItem(id: number): void {
    this.apiService.deleteCategory(id).subscribe({
      next: () => {
        this.items = this.items.filter(item => item.id !== id);
        this.cdr.detectChanges();
      },
      error: (err) => {
        console.error(err);
      }
    });
  }
  // getItemById(id: number): void {
  //   this.apiService.getCategoryById(id).subscribe({
  //     next: (response: Category) => {
  //       this.items = [response]; //spread operator
  //       this.cdr.detectChanges();
  //     },
  //     error: (err) => {
  //       console.error(err)
  //     }
  //   });
  // }
  updateItem(id: number): void { }
}
