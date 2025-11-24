import { Component } from '@angular/core';

export interface ContactInfo {
  email: string;
  phone: string;
  address?: string | null;
  isEligible?: "Y" | "N" | null;
}

@Component({
  selector: 'app-contact',
  imports: [],
  templateUrl: './contact.html',
  styleUrl: './contact.css',
})
export class Contact {
  //int, float, double,
  age: number = 0;
  name: string = '';
  isActive: boolean = false;
  rollNos: number[] = [];
  tempRollNos: Array<number> = [];
  contactInfo: ContactInfo = {
    email: '',
    phone: '',
    address: null,
    isEligible: 'Y',
  };
  contactList: ContactInfo[] = [];

  general: any = null;//accepts any data type

  updateArray(): void {
    this.tempRollNos.push(101);
    this.tempRollNos.push(102);
    this.tempRollNos.push(103);
    this.rollNos = this.tempRollNos; //reference copy : both point to same memory location
    this.rollNos = [...this.tempRollNos]; //spread operator: data is copied
  }

  addContact(): void {
    this.contactList.push(this.contactInfo);
  }
}
