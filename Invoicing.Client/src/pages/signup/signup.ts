import { Component, OnInit } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { SignupViewModel } from '../../view-models/SignupViewModel';
import { AuthProvider } from '../../providers/auth/auth';
import { InvoiceListPage } from '../invoice-list/invoice-list';

@IonicPage()
@Component({
  selector: 'page-signup',
  templateUrl: 'signup.html',
})
export class SignupPage implements OnInit {

  signupData: SignupViewModel;

  constructor(public navCtrl: NavController, 
    public navParams: NavParams,
    private auth: AuthProvider) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad SignupPage');
  }

  ngOnInit() {
    this.signupData = new SignupViewModel();
  }

  createAccount() {
    this.auth.post("Account/Signup", this.signupData).then(response => {
      if (response.State == 1) {
        this.navCtrl.push(InvoiceListPage);
      } else {
        console.log("Invalid Signup");
      }
    });
  }

}
