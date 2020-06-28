import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ExamService } from '../_services/exam.service';

@Component({
  selector: 'app-exam',
  templateUrl: './exam.component.html',
  styleUrls: ['./exam.component.css']
})
export class ExamComponent implements OnInit {

  constructor(private router: Router, private examService: ExamService) { }

  ngOnInit() {
}
}