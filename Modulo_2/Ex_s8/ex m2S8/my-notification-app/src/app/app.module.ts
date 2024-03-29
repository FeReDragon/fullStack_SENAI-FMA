import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NotificationListComponent } from './notification-list/notification-list.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

@NgModule({
declarations: [
AppComponent,
NotificationListComponent,
HeaderComponent,
FooterComponent
],
imports: [
  BrowserModule,
FontAwesomeModule
],
providers: [],
bootstrap: [AppComponent]
})
export class AppModule { }
