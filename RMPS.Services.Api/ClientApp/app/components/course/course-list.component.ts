import { finalize } from 'rxjs/operators';
//import { CourseService } from '../../services/course.service';
//import { Component, OnInit } from '@angular/core';
//import { SelectionEvent, GridDataResult, PageChangeEvent, DataStateChangeEvent } from '@progress/kendo-angular-grid';
//import { SortDescriptor, orderBy, State, GroupDescriptor, process } from '@progress/kendo-data-query';

import { Component, OnInit } from '@angular/core';
import { CourseService } from '../../services/course.service';
import { Observable } from 'rxjs/Rx';
import { filter, map } from 'rxjs/operators';
import { GridDataResult, DataStateChangeEvent } from '@progress/kendo-angular-grid';
import { DataSourceRequestState, DataResult } from '@progress/kendo-data-query';

@Component({
  selector: 'rmps-course',
  templateUrl: 'course-list.component.html',
  styleUrls: ['course-list.component.css']
})
export class CourseListComponent implements OnInit {
  public products: GridDataResult;
  public state: DataSourceRequestState = {
    skip: 0,
    take: 20
  };
  isLoading = false;

  constructor(private courseService: CourseService) { }

  ngOnInit() {
    this.loadGridData();
  }

  loadGridData() {
    this.isLoading = true;
    this.courseService.fetch(this.state)
      .pipe(finalize(() => this.isLoading = false))
      .subscribe(r => this.products = r);
  }
  public dataStateChange(state: DataStateChangeEvent): void {
    this.state = state;
    this.loadGridData();
  }
}