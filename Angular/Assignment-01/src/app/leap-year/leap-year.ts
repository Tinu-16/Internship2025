import { Component } from '@angular/core';

@Component({
  selector: 'app-leap-year',
  imports: [],
  templateUrl: './leap-year.html',
  styleUrl: './leap-year.scss',
})
export class LeapYear {
   
    result : string ="";

    isLeapYear(year: number):boolean
    {
       return (year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0);
    }

    checkLeapYear(value: string):void{
      const year = Number(value);
      const leap =this.isLeapYear(year);
      this.result=leap ? `${year} is a leap year` : `${year} is not a leap year`
    }
}
