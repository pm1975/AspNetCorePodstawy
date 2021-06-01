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

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }

  //this is request
  sendRequestToBackend() {
    var message = new Message();
    message.content = "JakasWiadomosc";
    message.author = "Piotr Mierniczak";

    this.http.post("https://localhost:5001/" + "kurs" + "/sendMessage", message).subscribe(response => {
      this.backendResponse = (response as any).content;
    },
      error => {
        this.backendResponse = error;
      })
  }

}
