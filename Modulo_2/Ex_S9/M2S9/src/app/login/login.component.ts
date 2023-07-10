import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  email: string | null = null;

  constructor(private router: Router) {}

  onSubmit() {
    if (this.email) {
      localStorage.setItem('email', this.email);
      this.router.navigate(['/home']);
    }
  }
}



