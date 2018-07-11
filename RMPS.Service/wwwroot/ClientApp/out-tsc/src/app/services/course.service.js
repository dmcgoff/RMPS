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
//import { Observable } from 'rxjs/Rx';
//import { HttpClient } from '@angular/common/http';
//import { Inject, Injectable } from '@angular/core';
var core_1 = require("@angular/core");
var http_1 = require("@angular/common/http");
var kendo_data_query_1 = require("@progress/kendo-data-query");
require("rxjs/add/operator/map");
//import { map } from 'rxjs/operators';
var CourseService = /** @class */ (function () {
    function CourseService(http) {
        this.http = http;
        this.BASE_URL = 'api/CourseCatalog';
    }
    CourseService.prototype.fetch = function (state) {
        var queryStr = "" + kendo_data_query_1.toDataSourceRequestString(state); // Serialize the state
        var hasGroups = state.group && state.group.length;
        return this.http
            .get(this.BASE_URL + "?" + queryStr) // Send the state to the server
            .map(function (_a) {
            var data = _a.data, total = _a.total /*, aggregateResults*/;
            return ({
                // If there are groups, convert them to a compatible format
                data: hasGroups ? kendo_data_query_1.translateDataSourceResultGroups(data) : data,
                total: total,
            });
        });
    };
    CourseService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.HttpClient])
    ], CourseService);
    return CourseService;
}());
exports.CourseService = CourseService;
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
//# sourceMappingURL=course.service.js.map