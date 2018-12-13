import { Component, OnInit } from '@angular/core';
import { NavController } from 'ionic-angular';
import { InvoiceListPage } from '../invoice-list/invoice-list';
import { LoginViewModel } from '../../view-models/LoginViewModel';
import { AuthProvider } from '../../providers/auth/auth';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage implements OnInit {

  loginData: LoginViewModel;

  constructor(public navCtrl: NavController,
     private auth: AuthProvider) {

  }

  ngOnInit() {
    this.loginData = new LoginViewModel();
  }

  login() {
    this.auth.post("Account/Login", this.loginData).then(response => {
      if (response.State == 1) {
        this.navCtrl.push(InvoiceListPage);
      } else {
        console.log("Invalid Login");
      }
    });
  }

}
