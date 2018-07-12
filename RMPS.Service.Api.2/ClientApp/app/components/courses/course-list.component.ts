import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { ICourse } from './course';
import { CourseService } from '../../services/course.service';

@Component({
  selector: 'rmps-course-list',
  templateUrl: './course-list.component.html',
  styleUrls: ['./course-list.component.css']
})
export class CourseListComponent implements OnInit {
  pageTitle: string = 'Course List';
  imageWidth: number = 50;
  imageMargin: number = 2;
  showImage: boolean = false;
  listFilter: string;
  errorMessage: string;

  courses: ICourse[];

  output: string;

  constructor(private productService: CourseService,
    private route: ActivatedRoute) { }

  toggleImage(): void {
    this.showImage = !this.showImage;
  }

  ngOnInit(): void {
    this.listFilter = this.route.snapshot.queryParams['filterBy'] || '';
    this.showImage = (this.route.snapshot.queryParams['showImage'] === 'true');
    // console.log(this.route.snapshot.queryParamMap.get('filterBy'));            

    this.productService.getCourses()
      .subscribe(courses => {
        this.courses = courses.data;
          this.output = JSON.stringify(courses.data);
        },
        error => this.errorMessage = <any>error);
  }
}
