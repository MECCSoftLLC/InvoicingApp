import { Component, OnInit } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { InvoiceDetailPage } from '../invoice-detail/invoice-detail';
import { ClientListPage } from '../client-list/client-list';
import { InvoiceViewModel } from '../../view-models/InvoiceViewModel';

@IonicPage()
@Component({
  selector: 'page-invoice-list',
  templateUrl: 'invoice-list.html',
})
export class InvoiceListPage implements OnInit {

  invoiceList: InvoiceViewModel[];

  constructor(public navCtrl: NavController, public navParams: NavParams) {
  }

  ngOnInit() {
    this.invoiceList = new Array();
    
    let sampleInvoice = new InvoiceViewModel();
    
    sampleInvoice.Id =  1;
    sampleInvoice.ClientId = 1;
    sampleInvoice.ClientName = "John Boo";
    sampleInvoice.Amount = 500;
    sampleInvoice.Status = "unpaid";
    sampleInvoice.InvoiceDate = new Date(2018,10,21);
    sampleInvoice.DueDate = new Date(2018,11,21);
    
    this.invoiceList.push(sampleInvoice);
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad InvoiceListPage');
  }

  clientList() {
    this.navCtrl.push(ClientListPage);
  }

  newInvoice() {
    this.navCtrl.push(InvoiceDetailPage);
  }

  invoiceDetail() {
    this.navCtrl.push(InvoiceDetailPage);
  }

}
