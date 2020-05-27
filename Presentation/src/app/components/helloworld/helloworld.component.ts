import { Component, OnInit } from '@angular/core';
import axios from 'axios';

// TODO pull this from an environment variable store
const api = 'http://localhost:5000/api/helloworld';

@Component({
  selector: 'app-helloworld',
  templateUrl: './helloworld.component.html',
  styleUrls: ['./helloworld.component.scss']
})
export class HelloworldComponent implements OnInit {
  helloWorlds = [];
  errors = [];

  constructor() { }

  ngOnInit(): void {
    // Get 10 values from the API. Could just save the first response,
    // but in this case we're assuming each value could be different
    for (let i = 0; i < 10; i++)
    {
      axios.get(api)
      .then((response) => {
        // handle success
        this.helloWorlds.push(response.data.helloWorldString);
      })
      .catch((error) => {
        // handle error
        console.log(error.response);
        this.errors.push(error.response);
      });
    }
  }
}
