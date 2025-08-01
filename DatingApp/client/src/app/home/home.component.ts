import { Component } from '@angular/core';
import { RegisterComponent } from "../register/register.component";

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [RegisterComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  registerMode = false;

  cancelRegisterMode(event: boolean) {
    this.registerMode = event;
  }
  
  registerToggle() {
    this.registerMode = !this.registerMode;
  }
}
