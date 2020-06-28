import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpEventType } from '@angular/common/http';
@Component({
  selector: 'app-viewdocs',
  templateUrl: './viewdocs.component.html',
  styleUrls: ['./viewdocs.component.css']
})
export class ViewdocsComponent implements OnInit {
public doc: any
constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get<any>('https://localhost:44320/Display').subscribe(data => {
      this.doc = data;
      this.doc.forEach(element => 
      { let splited = element.fileName.split('\\');
        element.name = splited[2]
      });
  })
  }

}
