import { Configuration } from '../app.constants';
import { Calculator } from '../calculator/calculator';
import { Injectable } from '@angular/core';
import { Http, Headers, Response } from '@angular/http';
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class CalculatorService {
    private actionUrl: string;
    private headers: Headers;

    constructor(
        private http: Http
    ) {
        this.actionUrl = Configuration.ServerWithApiUrl + 'calculation/';

        this.headers = new Headers();
        this.headers.append('Content-Type', 'application/json');
        this.headers.append('Accept', 'application/json');
    }

    public getHistory(): Observable<Calculator[]> {
        return this.http.get(this.actionUrl)
            .map((response: Response) => <Calculator[]>response.json());
    }

    public getcCalculationResult(input: string): Observable<Calculator> {
        return this.http.get(this.actionUrl + input)
            .map((response: Response) => <Calculator>response.json());
    }
}
