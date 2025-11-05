import { Component } from '@angular/core';

@Component({
  selector: 'app-alert',
  imports: [],
  templateUrl: './alert.html',
  styleUrls: ['./alert.scss'],
})
export class Alert{
  showAlert() {
      alert("Hello World");
      console.log("clicked");
      
    }
}
