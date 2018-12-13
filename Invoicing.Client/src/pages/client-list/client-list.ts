import { Component, OnInit } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { InvoiceDetailPage } from '../invoice-detail/invoice-detail';
import { ClientDetailPage } from '../client-detail/client-detail';
import { ClientViewModel } from '../../view-models/ClientViewModel';

@IonicPage()
@Component({
  selector: 'page-client-list',
  templateUrl: 'client-list.html',
})
export class ClientListPage implements OnInit {

  clientList: ClientViewModel[];

  constructor(public navCtrl: NavController, public navParams: NavParams) {
  }

  ngOnInit() {
    this.clientList = new Array();
    
    let sampleClient = new ClientViewModel();
    
    sampleClient.Id =  1;
    sampleClient.FirstName = "John";
    sampleClient.LastName = "Boo";
    sampleClient.Email = "JohnBoo@gmail.com";
    sampleClient.Notes = "Notes here...";

    this.clientList.push(sampleClient);
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad ClientListPage');
  }

  addInvoice() {
    this.navCtrl.push(InvoiceDetailPage);
  }

  clientDetail() {
    this.navCtrl.push(ClientDetailPage);
  }

  newClient() {
    this.navCtrl.push(ClientDetailPage);
  }

}
