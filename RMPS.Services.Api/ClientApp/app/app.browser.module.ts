import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppModuleShared } from './app.shared.module';
import { AppComponent } from './components/app/app.component';

// Services
import { CourseService } from './services/course.service';

@NgModule({
    bootstrap: [ AppComponent ],
    imports: [
      BrowserModule,
      BrowserAnimationsModule,
      AppModuleShared
    ],
  providers: [
      CourseService,
      { provide: 'BASE_URL', useFactory: getBaseUrl }
    ]
})
export class AppModule {
}

export function getBaseUrl() {
    return document.getElementsByTagName('base')[0].href;
}

