import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { CourseListComponent  } from './components/courses/course-list.component';

import { CourseService } from "./services/course.service";


// Imports for loading & configuring the in-memory web api
import { InMemoryWebApiModule } from 'angular-in-memory-web-api';
import { CourseData } from './components/courses/course-data';



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
      InMemoryWebApiModule.forRoot(CourseData, { delay: 1000 }),
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
          { path: 'fetch-data', component: FetchDataComponent },
          { path: 'course-list', component: CourseListComponent },
            { path: '**', redirectTo: 'home' }
        ])
  ],
  providers: [
    CourseService
    ]
})
export class AppModuleShared {
}
