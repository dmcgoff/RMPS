"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
// Angular Modules
var animations_1 = require("@angular/platform-browser/animations");
var http_1 = require("@angular/common/http");
var platform_browser_1 = require("@angular/platform-browser");
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
// Kendo UI Modules
require("hammerjs");
//import { ChartsModule } from '@progress/kendo-angular-charts';
var kendo_angular_dropdowns_1 = require("@progress/kendo-angular-dropdowns");
var kendo_angular_dateinputs_1 = require("@progress/kendo-angular-dateinputs");
var kendo_angular_grid_1 = require("@progress/kendo-angular-grid");
var kendo_angular_dialog_1 = require("@progress/kendo-angular-dialog");
// Components
var app_component_1 = require("./app.component");
//import { RegionalSalesStatusComponent } from './components/regional-sales-status/regional-sales-status.component';
var courses_component_1 = require("./components/courses/courses.component");
// Services
//import { CountryService } from './services/country.service';
//import { OrderService } from './services/order.service';
var course_service_1 = require("./services/course.service");
var appRoutes = [
    { path: '', redirectTo: '/regional-sales-status', pathMatch: 'full' },
    { path: 'regional-sales-status', component: courses_component_1.CoursesComponent },
    { path: 'course-catalog', component: courses_component_1.CoursesComponent }
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent,
                //RegionalSalesStatusComponent,
                courses_component_1.CoursesComponent
            ],
            imports: [
                platform_browser_1.BrowserModule,
                animations_1.BrowserAnimationsModule,
                http_1.HttpClientModule,
                router_1.RouterModule.forRoot(appRoutes),
                //ChartsModule,
                kendo_angular_dropdowns_1.DropDownsModule,
                kendo_angular_dateinputs_1.DateInputsModule,
                kendo_angular_grid_1.GridModule,
                kendo_angular_dialog_1.DialogModule,
                kendo_angular_grid_1.ExcelModule,
                kendo_angular_dialog_1.DialogsModule
            ],
            providers: [
                //CountryService,
                course_service_1.CourseService,
                //ProductService,
                { provide: 'baseUrl', useValue: 'http://localhost:9000/api' }
            ],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
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
//# sourceMappingURL=app.module.js.map