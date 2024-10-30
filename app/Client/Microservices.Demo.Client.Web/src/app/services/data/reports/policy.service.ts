import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { IReportPolicy } from '../../../models/ireport-policy';
import { map, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ReportPolicyService {
  port = '44399';
  //baseUrl = `${this.window.location.protocol}//${this.window.location.hostname}:${this.port}`;
  baseUrl = `http://${this.window.location.hostname}:${this.port}`;
  reportPolicyApiUrl = this.baseUrl + '/api/Report/policy';

  constructor(
    private http: HttpClient,
    @Inject('Window') private window: Window
  ) { }

  getPolicies(): Observable<IReportPolicy[]> {
    return this.http.get<IReportPolicy[]>(this.reportPolicyApiUrl)
      .pipe(catchError(this.handleError));
  }

  private handleError(error: HttpErrorResponse) {
    console.error('server error', error);
    if (error.error instanceof Error) {
      const erroMessage = error.message;
      return throwError(() => erroMessage);
    }
    return throwError(() => error || 'server error');
  }
}

