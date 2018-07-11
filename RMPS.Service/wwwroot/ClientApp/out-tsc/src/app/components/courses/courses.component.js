"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
//import { CourseService } from '../../services/course.service';
//import { Component, OnInit } from '@angular/core';
//import { SelectionEvent, GridDataResult, PageChangeEvent, DataStateChangeEvent } from '@progress/kendo-angular-grid';
//import { SortDescriptor, orderBy, State, GroupDescriptor, process } from '@progress/kendo-data-query';
var core_1 = require("@angular/core");
var course_service_1 = require("../../services/course.service");
var CoursesComponent = /** @class */ (function () {
    function CoursesComponent(courseService) {
        this.courseService = courseService;
        this.state = {
            skip: 0,
            take: 5
        };
    }
    CoursesComponent.prototype.ngOnInit = function () {
        this.loadGridData();
    };
    CoursesComponent.prototype.loadGridData = function () {
        var _this = this;
        this.courseService.fetch(this.state).subscribe(function (r) { return _this.products = r; });
    };
    CoursesComponent.prototype.dataStateChange = function (state) {
        var _this = this;
        this.state = state;
        this.courseService.fetch(state)
            .subscribe(function (r) { return _this.products = r; });
    };
    CoursesComponent = __decorate([
        core_1.Component({
            selector: 'rmps-courses',
            templateUrl: './courses.component.html',
            styleUrls: ['./courses.component.css']
        }),
        __metadata("design:paramtypes", [course_service_1.CourseService])
    ], CoursesComponent);
    return CoursesComponent;
}());
exports.CoursesComponent = CoursesComponent;
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
//# sourceMappingURL=courses.component.js.map