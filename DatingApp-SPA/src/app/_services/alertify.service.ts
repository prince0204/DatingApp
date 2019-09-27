import { Injectable } from '@angular/core';
declare let alertify: any;
@Injectable({
  providedIn: 'root'
})
export class AlertifyService {
  constructor() {}
  Confirm(message: string, onCallback: () => any) {
    // tslint:disable-next-line: only-arrow-functions
    alertify.confirm(message, function(e) {
      if (e) {
        onCallback();
      } else {
      }
    });
  }
  Success(message: string) {
    alertify.success(message);
  }
  Error(message: string) {
    alertify.error(message);
  }
  Warning(message: string) {
    alertify.warning(message);
  }
  Message(message: string) {
    alertify.message(message);
  }
}
