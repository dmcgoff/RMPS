
import { finalize } from 'rxjs/operators';
//import { CourseService } from '../../services/course.service';
//import { Component, OnInit } from '@angular/core';
//import { SelectionEvent, GridDataResult, PageChangeEvent, DataStateChangeEvent } from '@progress/kendo-angular-grid';
//import { SortDescriptor, orderBy, State, GroupDescriptor, process } from '@progress/kendo-data-query';

import { Component, OnInit } from '@angular/core';
import { CourseService } from '../../services/course.service';
import { Observable } from 'rxjs';
import { GridDataResult, DataStateChangeEvent } from '@progress/kendo-angular-grid';
import { DataSourceRequestState, DataResult } from '@progress/kendo-data-query';






@Component({
    selector: 'rmps-courses',
    templateUrl: './courses.component.html',
    styleUrls: ['./courses.component.css']
})
export class CoursesComponent implements OnInit {
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




//export class CoursesComponent implements OnInit {

//    orders: GridDataResult = { data: [], total: 0 };
//    selectedOrderInfo: any = {};

//    isLoading = false;

//    state: State = {
//        sort: [],
//        skip: 0,
//        take: 10,
//        group: [],
//    };

//    constructor(private courseService: CourseService) { }

//    ngOnInit() {
//        this.loadGridData();
//    }

//    loadGridData() {
//        this.isLoading = true;
//        this.courseService.getOrders().pipe(
//            finalize(() => this.isLoading = false))
//            .subscribe(data => {
//                this.orders = process(data, this.state);
//            });
//    }

//    onGridSelectionChange(selection: SelectionEvent) {
//        const row = selection.selectedRows[0];
//        //const orderId = row.dataItem.OrderID;

//        //this.courseService.getOrderInformation(orderId)
//        //    .subscribe(orderInfo => {
//        //        this.selectedOrderInfo = orderInfo;
//        //        this.openOrderDetailsDialog();
//        //    });
//    }

//    onGridDataStateChange(state: State) {
//        this.state = state;
//        this.loadGridData();
//    }

//    // onGridSortChange(sort: SortDescriptor[]) {
//    //     this.state.sort = sort;
//    //     this.loadGridData();
//    // }

//    // onGridPageChange(event: PageChangeEvent) {
//    //     this.state.skip = event.skip;
//    //     this.loadGridData();
//    // }

//    // onGridGroupChange(group: GroupDescriptor[]) {
//    //     this.state.group = group;
//    //     this.loadGridData();
//    // }

//    // onGridFilterChange(filter) {2
//    //     this.state.filter = filter;
//    //     this.loadGridData();
//    // }

//    //openOrderDetailsDialog() {
//    //    this.orderDetailsDialogOpened = true;
//    //}

//    //closeOrderDetailsDialog() {
//    //    this.orderDetailsDialogOpened = false;
//    //}
//}
