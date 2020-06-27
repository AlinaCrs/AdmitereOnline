import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { HttpClient, HttpEventType } from '@angular/common/http';

@Component({
  selector: 'app-documente',
  templateUrl: './documente.component.html',
  styleUrls: ['./documente.component.css']
})
export class DocumenteComponent implements OnInit {
  public progress: number;
  public message: string;
  @Output() public onUploadFinished = new EventEmitter();

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  // public uploadFile = (files) => {
  //   // tslint:disable-next-line: no-debugger
  //   debugger;
  //   if (files.length === 0) {
  //     return;
  //   }

  //   let fileToUpload = files[0] as File;
  //   const formData = new FormData();
  //   formData.append('file', fileToUpload, fileToUpload.name);

  //   this.http.post('http://localhost:5000/upload', formData, {reportProgress: true, observe: 'events'})
  //     .subscribe(event => {
  //       if (event.type === HttpEventType.UploadProgress) {
  //         this.progress = Math.round(100 * event.loaded / event.total);
  //       }
  //       else if (event.type === HttpEventType.Response) {
  //         this.message = 'Upload success.';
  //         this.onUploadFinished.emit(event.body);
  //       }
  //     });
  // }

  public uploadFile = (files) => {
    if (files.length === 0) {
      return;
    }

    let filesToUpload : File[] = files;
    const formData = new FormData();

    Array.from(filesToUpload).map((file, index) => {
      return formData.append('file'+index, file, file.name);
    });

    this.http.post('http://localhost:5000/upload', formData, {reportProgress: true, observe: 'events'})
      .subscribe(event => {
        if (event.type === HttpEventType.UploadProgress)
          this.progress = Math.round(100 * event.loaded / event.total);
        else if (event.type === HttpEventType.Response) {
          this.message = 'Upload success.';
          this.onUploadFinished.emit(event.body);
        }
      });
  }
}
