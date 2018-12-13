import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { environment } from '../../environment.js';
import { RequestResult } from './RequestResult.js';

@Injectable()
export class AuthProvider {

  constructor(public http: HttpClient) {
    console.log('Hello AuthProvider Provider');
  }

  get(url): Promise<RequestResult> {
    return this.http.get(environment.url + url).toPromise()
      .then(response => response as RequestResult)
      .catch(this.handleError);
  }

  post(url: string, body: any): Promise<RequestResult> {
    return this.http.post(environment.url + url, body).toPromise()
      .then(response => response as RequestResult)
      .catch(this.handleError);
  }

  put(url: string, body: any): Promise<RequestResult> {
    return this.http.put(environment.url + url, body).toPromise()
      .then(response => response as RequestResult)
      .catch(this.handleError);
  }

  delete(url: string, body: any): Promise<RequestResult> {
    return this.http.delete(environment.url + url).toPromise()
      .then(response => response as RequestResult)
      .catch(this.handleError);
  }
  
  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error);
    return Promise.reject(error.message || error);
  }

}
