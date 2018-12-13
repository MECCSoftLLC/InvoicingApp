import { Component, OnInit } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { ClientViewModel } from '../../view-models/ClientViewModel';

@IonicPage()
@Component({
  selector: 'page-client-detail',
  templateUrl: 'client-detail.html',
})
export class ClientDetailPage implements OnInit {

  clientData: ClientViewModel;

  constructor(public navCtrl: NavController, public navParams: NavParams) {
  }

  ngOnInit() {
    this.clientData = new ClientViewModel();
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad ClientDetailPage');
  }

}
