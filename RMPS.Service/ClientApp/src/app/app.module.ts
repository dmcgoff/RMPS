// Angular Modules
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

// Kendo UI Modules
import 'hammerjs';
//import { ChartsModule } from '@progress/kendo-angular-charts';
import { DropDownsModule } from '@progress/kendo-angular-dropdowns';
import { DateInputsModule } from '@progress/kendo-angular-dateinputs';
import { GridModule, ExcelModule } from '@progress/kendo-angular-grid';
import { DialogModule, DialogsModule } from '@progress/kendo-angular-dialog';

// Components
import { AppComponent } from './app.component';
//import { RegionalSalesStatusComponent } from './components/regional-sales-status/regional-sales-status.component';
import { CoursesComponent } from './components/courses/courses.component';

// Services
//import { CountryService } from './services/country.service';
//import { OrderService } from './services/order.service';
import { CourseService } from './services/course.service';

const appRoutes: Routes = [
    { path: '', redirectTo: '/regional-sales-status', pathMatch: 'full' },
    { path: 'regional-sales-status', component: CoursesComponent },
    { path: 'course-catalog', component: CoursesComponent }
];

@NgModule({
    declarations: [
        AppComponent,
        //RegionalSalesStatusComponent,
        CoursesComponent
    ],
    imports: [
        BrowserModule,
        BrowserAnimationsModule,
        HttpClientModule,
        RouterModule.forRoot(appRoutes),
        //ChartsModule,
        DropDownsModule,
        DateInputsModule,
        GridModule,
        DialogModule,
        ExcelModule,
        DialogsModule
    ],
    providers: [
        //CountryService,
        CourseService,
        //ProductService,
        { provide: 'baseUrl', useValue: 'http://localhost:9000/api' }
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }








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
