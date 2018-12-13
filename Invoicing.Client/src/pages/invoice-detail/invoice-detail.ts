import { Component, OnInit } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { InvoiceViewModel } from '../../view-models/InvoiceViewModel';

@IonicPage()
@Component({
  selector: 'page-invoice-detail',
  templateUrl: 'invoice-detail.html',
})
export class InvoiceDetailPage implements OnInit {

  invoiceData: InvoiceViewModel;

  constructor(public navCtrl: NavController, public navParams: NavParams) {
  }

  ngOnInit() {
    this.invoiceData = new InvoiceViewModel();
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad InvoiceDetailPage');
  }

}
