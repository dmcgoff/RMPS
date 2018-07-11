import { map } from 'rxjs/operators';
//import { Observable } from 'rxjs/Rx';
//import { HttpClient } from '@angular/common/http';
//import { Inject, Injectable } from '@angular/core';


import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {
    toDataSourceRequestString,
    translateDataSourceResultGroups,
    translateAggregateResults,
    DataResult,
    DataSourceRequestState
    } from '@progress/kendo-data-query';
import { GridDataResult, DataStateChangeEvent } from '@progress/kendo-angular-grid';
import { Observable } from 'rxjs';
import 'rxjs/add/operator/map';
//import { map } from 'rxjs/operators';

@Injectable()
export class CourseService {
    private BASE_URL: string = 'api/CourseCatalog';

    constructor(private http: HttpClient) { }

    public fetch(state: DataSourceRequestState): Observable<DataResult> {
        const queryStr = `${toDataSourceRequestString(state)}`; // Serialize the state
        const hasGroups = state.group && state.group.length;

        return this.http
            .get(`${this.BASE_URL}?${queryStr}`) // Send the state to the server
            .map(({ data, total /*, aggregateResults*/ }: GridDataResult) => // Process the response
                (<GridDataResult>{
                    // If there are groups, convert them to a compatible format
                    data: hasGroups ? translateDataSourceResultGroups(data) : data,
                    total: total,
                    // Convert the aggregates if such exist
                    //aggregateResult: translateAggregateResults(aggregateResults)
                })
            );
    }
}





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
