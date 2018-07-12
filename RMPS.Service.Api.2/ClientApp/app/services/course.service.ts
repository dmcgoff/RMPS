import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/map';
import 'rxjs/add/observable/of';

import { ICourse } from "../components/courses/course";

export interface DataResult {
  /**
   * The data that will be rendered by the Grid as an array.
   */
  data: any[];
  /**
   * The total number of records that are available.
   */
  total: number;
}

export interface GridDataResult extends DataResult {
}

//class GridDataResult {
//  data: ICourse[];
//  total: number;
//  aggregateResults: string;
//  errors: string;
//}





@Injectable()
export class CourseService {
  private baseUrl = 'api/courses';

  constructor(private http: Http) { }

  //getCourses(): Observable<ICourse[]> {
  //  return this.http.get(this.baseUrl)
  //    .map(this.extractData)
  //    .do(data => console.log('getProducts: ' + JSON.stringify(data)))
  //    .catch(this.handleError);
  //}

  

  getCourses(): Observable<DataResult> {
    return this.http.get(this.baseUrl)
      .map(this.extractData)
      //.do(data => console.log('getProducts: ' + JSON.stringify(data)))
      .catch(this.handleError);



  }


  //  .get(`${this.BASE_URL}?${queryStr}`) // Send the state to the server
  //  .map<GridDataResult>(({ data, total /*, aggregateResults*/ }: GridDataResult) => // Process the response
  //    (<GridDataResult>{
  //      // If there are groups, convert them to a compatible format
  //      data: hasGroups ? translateDataSourceResultGroups(data) : data,
  //      total: total,
  //      // Convert the aggregates if such exist
  //      //aggregateResult: translateAggregateResults(aggregateResults)
  //    })
  //  );



  //getProduct(id: number): Observable<ICourse> {
  //  if (id === 0) {
  //    return Observable.of(this.initializeProduct());
  //  };
  //  const url = `${this.baseUrl}/${id}`;
  //  return this.http.get(url)
  //    .map(this.extractData)
  //    .do(data => console.log('getProduct: ' + JSON.stringify(data)))
  //    .catch(this.handleError);
  //}

  //deleteProduct(id: number): Observable<Response> {
  //  let headers = new Headers({ 'Content-Type': 'application/json' });
  //  let options = new RequestOptions({ headers: headers });

  //  const url = `${this.baseUrl}/${id}`;
  //  return this.http.delete(url, options)
  //    .do(data => console.log('deleteProduct: ' + JSON.stringify(data)))
  //    .catch(this.handleError);
  //}

  //saveProduct(product: ICourse): Observable<ICourse> {
  //  let headers = new Headers({ 'Content-Type': 'application/json' });
  //  let options = new RequestOptions({ headers: headers });

  //  if (product.id === 0) {
  //    return this.createProduct(product, options);
  //  }
  //  return this.updateProduct(product, options);
  //}

  //private createProduct(product: ICourse, options: RequestOptions): Observable<ICourse> {
  //  //product.id = undefined;
  //  return this.http.post(this.baseUrl, product, options)
  //    .map(this.extractData)
  //    .do(data => console.log('createProduct: ' + JSON.stringify(data)))
  //    .catch(this.handleError);
  //}

  //private updateProduct(product: ICourse, options: RequestOptions): Observable<ICourse> {
  //  const url = `${this.baseUrl}/${product.id}`;
  //  return this.http.put(url, product, options)
  //    .map(() => product)
  //    .do(data => console.log('updateProduct: ' + JSON.stringify(data)))
  //    .catch(this.handleError);
  //}

  private translateDataSourceResultGroups(data: any) { }

  private extractData(response: Response) {
    const body = response.json();
    const responseData = body.data;


    console.log('extractData: ' + JSON.stringify(body));

    const hasGroups = false;

    return <GridDataResult>{

      // If there are groups, convert them to a compatible format
      data: hasGroups ? this.translateDataSourceResultGroups(body.data) : responseData.data,
      total: responseData.total,
      // Convert the aggregates if such exist
      //aggregateResult: translateAggregateResults(aggregateResults)
    }





    //return body.data || {};
  }

  private handleError(error: Response): Observable<any> {
    // in a real world app, we may send the server to some remote logging infrastructure
    // instead of just logging it to the console
    console.error(error);
    return Observable.throw(error.json().error || 'Server error');
  }

  //initializeProduct(): ICourse {
  //  // Return an initialized object
  //  return {
  //    id: 0,
  //    productName: '',
  //    productCode: '',
  //    category: '',
  //    tags: [],
  //    releaseDate: '',
  //    price: 0,
  //    description: '',
  //    starRating: 0,
  //    imageUrl: ''
  //  };
  //}
}
