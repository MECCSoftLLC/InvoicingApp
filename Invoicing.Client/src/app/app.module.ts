import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';

import { MyApp } from './app.component';
import { HomePage } from '../pages/home/home';
import { InvoiceListPageModule } from '../pages/invoice-list/invoice-list.module';
import { ClientListPageModule } from '../pages/client-list/client-list.module';
import { ClientDetailPageModule } from '../pages/client-detail/client-detail.module';
import { InvoiceDetailPageModule } from '../pages/invoice-detail/invoice-detail.module';
import { AuthProvider } from '../providers/auth/auth';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    MyApp,
    HomePage
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    InvoiceListPageModule,
    ClientListPageModule,
    ClientDetailPageModule,
    InvoiceDetailPageModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    HomePage
  ],
  providers: [
    StatusBar,
    SplashScreen,
    {provide: ErrorHandler, useClass: IonicErrorHandler},
    AuthProvider
  ]
})
export class AppModule {}
