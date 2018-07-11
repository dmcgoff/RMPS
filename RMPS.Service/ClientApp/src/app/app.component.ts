import { CourseService } from './services/course.service';
import { Component, OnInit } from '@angular/core';
//import Courseservice = require("./services/course.service");
//import CourseService = Courseservice.CourseService;

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
    title = '{ Dashboard }';
    isWebApiUp = true;

    constructor(private courseService: CourseService) { }

    ngOnInit() {
        //this.courseService.getOrders()
        //    .subscribe(() => { }, err => this.isWebApiUp = false);
    }
}
