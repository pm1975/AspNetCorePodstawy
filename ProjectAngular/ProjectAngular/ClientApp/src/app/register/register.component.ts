import { Component, OnInit } from '@angular/core';
import { UserRegisterDto } from '../models/user-register-dto.model';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  userRegisterDto = new UserRegisterDto();

  constructor() { }

  ngOnInit(): void {
  }

}
