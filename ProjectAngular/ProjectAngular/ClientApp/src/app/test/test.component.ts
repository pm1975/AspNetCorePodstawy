import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

export class Message {
  content: string;
  author: string;
}

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  backendResponse: string;
  firstName: string;
  lastName: string;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get("https://localhost:44364/" + "account" + "/getCurrentUser").subscribe(response => {
      this.firstName = (response as any).firstName;
      this.lastName = (response as any).lastName;
    },
      error => {
      })
  }

  //this is request
  sendRequestToBackend() {
    var message = new Message();
    message.content = "JakasWiadomosc";
    message.author = "Piotr Mierniczak";

    this.http.post("https://localhost:44364/" + "kurs" + "/sendMessage", message).subscribe(response => {
      this.backendResponse = (response as any).content;
    },
      error => {
        this.backendResponse = error;
      })
  }

}
