(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./ClientApp/src/$$_lazy_route_resource lazy recursive":
/*!********************************************************************!*\
  !*** ./ClientApp/src/$$_lazy_route_resource lazy namespace object ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error('Cannot find module "' + req + '".');
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./ClientApp/src/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./ClientApp/src/app/app.component.css":
/*!*********************************************!*\
  !*** ./ClientApp/src/app/app.component.css ***!
  \*********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./ClientApp/src/app/app.component.html":
/*!**********************************************!*\
  !*** ./ClientApp/src/app/app.component.html ***!
  \**********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"main-wrapper\">\r\n    <aside class=\"nav-section\">\r\n        <h1>{{title}}</h1>\r\n        <h3 style=\"color: red\" *ngIf=\"!isWebApiUp\">The Web API is not running.</h3>\r\n        <ul>\r\n            <li>\r\n                <a routerLink=\"/regional-sales-status\" routerLinkActive=\"active-link\">Regional Sales Status</a>\r\n            </li>\r\n            <li>\r\n                <a routerLink=\"/course-catalog\" routerLinkActive=\"active-link\">Course Catalog</a>\r\n            </li>\r\n            <!-- <li>\r\n                <a routerLink=\"/team-efficiency\"><span class=\"icon icon-faves\"></span>Team Efficiency</a>\r\n            </li> -->\r\n        </ul>\r\n        <div class=\"rights\">\r\n            &copy; New Venture Software\r\n        </div>\r\n    </aside>\r\n    <section class=\"main-section\">\r\n        <router-outlet></router-outlet>\r\n    </section>\r\n</div>\r\n"

/***/ }),

/***/ "./ClientApp/src/app/app.component.ts":
/*!********************************************!*\
  !*** ./ClientApp/src/app/app.component.ts ***!
  \********************************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var _services_course_service__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./services/course.service */ "./ClientApp/src/app/services/course.service.ts");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


//import Courseservice = require("./services/course.service");
//import CourseService = Courseservice.CourseService;
var AppComponent = /** @class */ (function () {
    function AppComponent(courseService) {
        this.courseService = courseService;
        this.title = '{ Dashboard }';
        this.isWebApiUp = true;
    }
    AppComponent.prototype.ngOnInit = function () {
        //this.courseService.getOrders()
        //    .subscribe(() => { }, err => this.isWebApiUp = false);
    };
    AppComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-root',
            template: __webpack_require__(/*! ./app.component.html */ "./ClientApp/src/app/app.component.html"),
            styles: [__webpack_require__(/*! ./app.component.css */ "./ClientApp/src/app/app.component.css")]
        }),
        __metadata("design:paramtypes", [_services_course_service__WEBPACK_IMPORTED_MODULE_0__["CourseService"]])
    ], AppComponent);
    return AppComponent;
}());



/***/ }),

/***/ "./ClientApp/src/app/app.module.ts":
/*!*****************************************!*\
  !*** ./ClientApp/src/app/app.module.ts ***!
  \*****************************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm5/animations.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var hammerjs__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! hammerjs */ "./node_modules/hammerjs/hammer.js");
/* harmony import */ var hammerjs__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(hammerjs__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var _progress_kendo_angular_dropdowns__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @progress/kendo-angular-dropdowns */ "./node_modules/@progress/kendo-angular-dropdowns/dist/es/index.js");
/* harmony import */ var _progress_kendo_angular_dateinputs__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @progress/kendo-angular-dateinputs */ "./node_modules/@progress/kendo-angular-dateinputs/dist/es/index.js");
/* harmony import */ var _progress_kendo_angular_grid__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @progress/kendo-angular-grid */ "./node_modules/@progress/kendo-angular-grid/dist/es/index.js");
/* harmony import */ var _progress_kendo_angular_dialog__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @progress/kendo-angular-dialog */ "./node_modules/@progress/kendo-angular-dialog/dist/es/index.js");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./app.component */ "./ClientApp/src/app/app.component.ts");
/* harmony import */ var _components_courses_courses_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./components/courses/courses.component */ "./ClientApp/src/app/components/courses/courses.component.ts");
/* harmony import */ var _services_course_service__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./services/course.service */ "./ClientApp/src/app/services/course.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
// Angular Modules





// Kendo UI Modules

//import { ChartsModule } from '@progress/kendo-angular-charts';




// Components

//import { RegionalSalesStatusComponent } from './components/regional-sales-status/regional-sales-status.component';

// Services
//import { CountryService } from './services/country.service';
//import { OrderService } from './services/order.service';

var appRoutes = [
    { path: '', redirectTo: '/regional-sales-status', pathMatch: 'full' },
    { path: 'regional-sales-status', component: _components_courses_courses_component__WEBPACK_IMPORTED_MODULE_11__["CoursesComponent"] },
    { path: 'course-catalog', component: _components_courses_courses_component__WEBPACK_IMPORTED_MODULE_11__["CoursesComponent"] }
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_3__["NgModule"])({
            declarations: [
                _app_component__WEBPACK_IMPORTED_MODULE_10__["AppComponent"],
                //RegionalSalesStatusComponent,
                _components_courses_courses_component__WEBPACK_IMPORTED_MODULE_11__["CoursesComponent"]
            ],
            imports: [
                _angular_platform_browser__WEBPACK_IMPORTED_MODULE_2__["BrowserModule"],
                _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_0__["BrowserAnimationsModule"],
                _angular_common_http__WEBPACK_IMPORTED_MODULE_1__["HttpClientModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forRoot(appRoutes),
                //ChartsModule,
                _progress_kendo_angular_dropdowns__WEBPACK_IMPORTED_MODULE_6__["DropDownsModule"],
                _progress_kendo_angular_dateinputs__WEBPACK_IMPORTED_MODULE_7__["DateInputsModule"],
                _progress_kendo_angular_grid__WEBPACK_IMPORTED_MODULE_8__["GridModule"],
                _progress_kendo_angular_dialog__WEBPACK_IMPORTED_MODULE_9__["DialogModule"],
                _progress_kendo_angular_grid__WEBPACK_IMPORTED_MODULE_8__["ExcelModule"],
                _progress_kendo_angular_dialog__WEBPACK_IMPORTED_MODULE_9__["DialogsModule"]
            ],
            providers: [
                //CountryService,
                _services_course_service__WEBPACK_IMPORTED_MODULE_12__["CourseService"],
                //ProductService,
                { provide: 'baseUrl', useValue: 'http://localhost:9000/api' }
            ],
            bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_10__["AppComponent"]]
        })
    ], AppModule);
    return AppModule;
}());

//import { BrowserModule } from '@angular/platform-browser';
//import { NgModule } from '@angular/core';
//import { AppComponent } from './app.component';
//import { GridModule } from '@progress/kendo-angular-grid';
//import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
//@NgModule({
//  declarations: [
//    AppComponent
//  ],
//  imports: [
//    BrowserModule,
//    GridModule,
//    BrowserAnimationsModule
//  ],
//  providers: [],
//  bootstrap: [AppComponent]
//})
//export class AppModule { }


/***/ }),

/***/ "./ClientApp/src/app/components/courses/courses.component.css":
/*!********************************************************************!*\
  !*** ./ClientApp/src/app/components/courses/courses.component.css ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./ClientApp/src/app/components/courses/courses.component.html":
/*!*********************************************************************!*\
  !*** ./ClientApp/src/app/components/courses/courses.component.html ***!
  \*********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"container\">\r\n    <h3>Products and Orders</h3>\r\n    <div style=\"position: relative\">\r\n        \r\n        <kendo-grid\r\n            [data]=\"products\" [height]=\"500\"\r\n            [sortable]=\"true\" [sort]=\"state.sort\"\r\n            [pageable]=\"true\" [skip]=\"state.skip\" [pageSize]=\"state.take\"\r\n            [groupable]=\"true\" [group]=\"state.group\"\r\n            [filterable]=\"true\" [filter]=\"state.filter\"\r\n            [scrollable]=\"'scrollable'\"\r\n            (dataStateChange)=\"dataStateChange($event)\">\r\n            \r\n            <ng-template kendoGridToolbarTemplate>\r\n                <button type=\"button\" kendoGridExcelCommand><span class=\"k-icon k-i-file-excel\"></span>Export to Excel</button>\r\n            </ng-template>\r\n\r\n            <kendo-grid-column field=\"courseId\" title=\"Course Id\" width=\"50px\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"courseName\" title=\"Name\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"specialty\" title=\"Specialty\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"description\" title=\"Description\" width=\"150px\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"reviewDate\" title=\"Review Date\" format=\"{0:MM/dd/yyyy}\" filter=\"date\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"releaseDate\" title=\"Release Date\" format=\"{0:MM/dd/yyyy}\" filter=\"date\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"expirationDate\" title=\"Expiration Date\" format=\"{0:MM/dd/yyyy}\" filter=\"date\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"credits\" title=\"Credits\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"cMECert\" title=\"CME Cert\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"cNECert\" title=\"CNE Cert\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"riskSpecific\" title=\"Risk Specific\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"settings\" title=\"Settings\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"medicalRole\" title=\"Medical Role\"></kendo-grid-column>\r\n            <kendo-grid-column field=\"state\" title=\"State\"></kendo-grid-column>\r\n\r\n            <kendo-grid-excel fileName=\"CourseCatalog.xlsx\"></kendo-grid-excel>\r\n        </kendo-grid>\r\n        <div *ngIf=\"isLoading\" class=\"spinner-wrapper\">\r\n            <span class=\"k-icon k-i-loading spinner\"></span>\r\n        </div>\r\n    </div>\r\n</div>\r\n"

/***/ }),

/***/ "./ClientApp/src/app/components/courses/courses.component.ts":
/*!*******************************************************************!*\
  !*** ./ClientApp/src/app/components/courses/courses.component.ts ***!
  \*******************************************************************/
/*! exports provided: CoursesComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CoursesComponent", function() { return CoursesComponent; });
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm5/operators/index.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _services_course_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../services/course.service */ "./ClientApp/src/app/services/course.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

//import { CourseService } from '../../services/course.service';
//import { Component, OnInit } from '@angular/core';
//import { SelectionEvent, GridDataResult, PageChangeEvent, DataStateChangeEvent } from '@progress/kendo-angular-grid';
//import { SortDescriptor, orderBy, State, GroupDescriptor, process } from '@progress/kendo-data-query';


var CoursesComponent = /** @class */ (function () {
    function CoursesComponent(courseService) {
        this.courseService = courseService;
        this.state = {
            skip: 0,
            take: 20
        };
        this.isLoading = false;
    }
    CoursesComponent.prototype.ngOnInit = function () {
        this.loadGridData();
    };
    CoursesComponent.prototype.loadGridData = function () {
        var _this = this;
        this.isLoading = true;
        this.courseService.fetch(this.state)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_0__["finalize"])(function () { return _this.isLoading = false; }))
            .subscribe(function (r) { return _this.products = r; });
    };
    CoursesComponent.prototype.dataStateChange = function (state) {
        this.state = state;
        this.loadGridData();
    };
    CoursesComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'rmps-courses',
            template: __webpack_require__(/*! ./courses.component.html */ "./ClientApp/src/app/components/courses/courses.component.html"),
            styles: [__webpack_require__(/*! ./courses.component.css */ "./ClientApp/src/app/components/courses/courses.component.css")]
        }),
        __metadata("design:paramtypes", [_services_course_service__WEBPACK_IMPORTED_MODULE_2__["CourseService"]])
    ], CoursesComponent);
    return CoursesComponent;
}());

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


/***/ }),

/***/ "./ClientApp/src/app/services/course.service.ts":
/*!******************************************************!*\
  !*** ./ClientApp/src/app/services/course.service.ts ***!
  \******************************************************/
/*! exports provided: CourseService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CourseService", function() { return CourseService; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _progress_kendo_data_query__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/kendo-data-query */ "./node_modules/@progress/kendo-data-query/dist/es/main.js");
/* harmony import */ var rxjs_add_operator_map__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs/add/operator/map */ "./node_modules/rxjs-compat/_esm5/add/operator/map.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
//import { Observable } from 'rxjs/Rx';
//import { HttpClient } from '@angular/common/http';
//import { Inject, Injectable } from '@angular/core';




//import { map } from 'rxjs/operators';
var CourseService = /** @class */ (function () {
    function CourseService(http) {
        this.http = http;
        this.BASE_URL = 'api/CourseCatalog';
    }
    CourseService.prototype.fetch = function (state) {
        var queryStr = "" + Object(_progress_kendo_data_query__WEBPACK_IMPORTED_MODULE_2__["toDataSourceRequestString"])(state); // Serialize the state
        var hasGroups = state.group && state.group.length;
        return this.http
            .get(this.BASE_URL + "?" + queryStr) // Send the state to the server
            .map(function (_a) {
            var data = _a.data, total = _a.total /*, aggregateResults*/;
            return ({
                // If there are groups, convert them to a compatible format
                data: hasGroups ? Object(_progress_kendo_data_query__WEBPACK_IMPORTED_MODULE_2__["translateDataSourceResultGroups"])(data) : data,
                total: total,
            });
        });
    };
    CourseService = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injectable"])(),
        __metadata("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_1__["HttpClient"]])
    ], CourseService);
    return CourseService;
}());

//export class CourseService {
//    constructor(private http: HttpClient, @Inject('baseUrl') private baseUrl) { }
//    // GET /api/orders/
//    getOrders(): Observable<any[]> {
//        return this.http.get<any[]>(`${this.baseUrl}/coursecatalog`).pipe(
//            map(data => {
//                data.forEach(x => {
//                    x.OrderDate = new Date(x.OrderDate);
//                    if (x.ShippedDate)
//                        x.ShippedDate = new Date(x.ShippedDate);
//                });
//                return data;
//            }));
//    }
//    // GET /api/orders/:id
//    getOrderInformation(orderId: number): Observable<any> {
//        return this.http.get<any>(`${this.baseUrl}/orders/${orderId}`);
//    }
//}


/***/ }),

/***/ "./ClientApp/src/environments/environment.ts":
/*!***************************************************!*\
  !*** ./ClientApp/src/environments/environment.ts ***!
  \***************************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
var environment = {
    production: false
};
/*
 * In development mode, to ignore zone related error stack frames such as
 * `zone.run`, `zoneDelegate.invokeTask` for easier debugging, you can
 * import the following file, but please comment it out in production mode
 * because it will have performance impact when throw error
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./ClientApp/src/main.ts":
/*!*******************************!*\
  !*** ./ClientApp/src/main.ts ***!
  \*******************************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./ClientApp/src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./ClientApp/src/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(function (err) { return console.log(err); });


/***/ }),

/***/ 0:
/*!*************************************!*\
  !*** multi ./ClientApp/src/main.ts ***!
  \*************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\VSS\RMPS\RMPS\RMPS.Service\ClientApp\src\main.ts */"./ClientApp/src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map