// Angular Modules
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';


// Kendo UI Modules
//import 'hammerjs';
import { DropDownsModule } from '@progress/kendo-angular-dropdowns';
import { DateInputsModule } from '@progress/kendo-angular-dateinputs';
import { GridModule, ExcelModule } from '@progress/kendo-angular-grid';
import { DialogModule, DialogsModule } from '@progress/kendo-angular-dialog';

// App Components
import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { CourseListComponent } from './components/course/course-list.component';



const appRoutes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'course', component: HomeComponent },
  { path: '**', redirectTo: 'home' }
];


@NgModule({
    declarations: [
      AppComponent,
      NavMenuComponent,
      CounterComponent,
      FetchDataComponent,
      HomeComponent,
      CourseListComponent
    ],
    imports: [
      CommonModule,
      HttpModule,
      FormsModule,
      GridModule,
      DropDownsModule,
      DateInputsModule,
      GridModule,
      DialogModule,
      ExcelModule,
      DialogsModule,
      RouterModule.forRoot(appRoutes)
    ]
})
export class AppModuleShared {
}

