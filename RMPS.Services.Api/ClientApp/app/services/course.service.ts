import { Injectable } from '@angular/core';
import { Http, Response, Headers, URLSearchParams, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import {
  toDataSourceRequestString,
  translateDataSourceResultGroups,
  translateAggregateResults,
  DataResult,
  DataSourceRequestState
} from '@progress/kendo-data-query';
import { GridDataResult, DataStateChangeEvent } from '@progress/kendo-angular-grid';
//import { Observable } from 'rxjs';
//import 'rxjs/add/operator/map';

@Injectable()
export class CourseService {
  private BASE_URL: string = 'api/Course';

  constructor(private http: Http) { }
  //getArticleById(articleId: string): Observable<Article> {
  //  let cpHeaders = new Headers({ 'Content-Type': 'application/json' });
  //  let options = new RequestOptions({ headers: cpHeaders });
  //  console.log(this.articleUrl + "/" + articleId);
  //  return this.http.get(this.articleUrl + "/" + articleId)
  //    .map(this.extractData)
  //    .catch(this.handleError);
  //}
  public fetch(state: DataSourceRequestState): Observable<DataResult> {
    const queryStr = `${toDataSourceRequestString(state)}`; // Serialize the state
    const hasGroups = state.group && state.group.length;
    const cpHeaders = new Headers({ 'Content-Type': 'application/json' });
    const options = new RequestOptions({ headers: cpHeaders });

    //return this.http
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

    return this.http
      .get(`${this.BASE_URL}?${queryStr}`) // Send the state to the server
      .map(this.extractData)
      .catch(this.handleError);
  }


  private extractData(res: Response) {
    let body = res.json();
    return body;
  }
  private handleError(error: Response | any) {
    console.error(error.message || error);
    return Observable.throw(error.status);
  }
}

//import { Article } from './article';

//@Injectable()
//export class ArticleService {
//  //URL for CRUD operations
//  articleUrl = "http://localhost:3000/articles";
//  //Create constructor to get Http instance
//  constructor(private http: Http) {
//  }
//  //Fetch all articles
//  getAllArticles(): Observable<Article[]> {
//    return this.http.get(this.articleUrl)
//      .map(this.extractData)
//      .catch(this.handleError);

//  }
//  //Create article
//  createArticle(article: Article): Observable<number> {
//    let cpHeaders = new Headers({ 'Content-Type': 'application/json' });
//    let options = new RequestOptions({ headers: cpHeaders });
//    return this.http.post(this.articleUrl, article, options)
//      .map(success => success.status)
//      .catch(this.handleError);
//  }
//  //Fetch article by id
//  getArticleById(articleId: string): Observable<Article> {
//    let cpHeaders = new Headers({ 'Content-Type': 'application/json' });
//    let options = new RequestOptions({ headers: cpHeaders });
//    console.log(this.articleUrl + "/" + articleId);
//    return this.http.get(this.articleUrl + "/" + articleId)
//      .map(this.extractData)
//      .catch(this.handleError);
//  }
//  //Update article
//  updateArticle(article: Article): Observable<number> {
//    let cpHeaders = new Headers({ 'Content-Type': 'application/json' });
//    let options = new RequestOptions({ headers: cpHeaders });
//    return this.http.put(this.articleUrl + "/" + article.id, article, options)
//      .map(success => success.status)
//      .catch(this.handleError);
//  }
//  //Delete article	
//  deleteArticleById(articleId: string): Observable<number> {
//    let cpHeaders = new Headers({ 'Content-Type': 'application/json' });
//    let options = new RequestOptions({ headers: cpHeaders });
//    return this.http.delete(this.articleUrl + "/" + articleId)
//      .map(success => success.status)
//      .catch(this.handleError);
//  }
//  private extractData(res: Response) {
//    let body = res.json();
//    return body;
//  }
//  private handleError(error: Response | any) {
//    console.error(error.message || error);
//    return Observable.throw(error.status);
//  }
//}




//import { map } from 'rxjs/operators';
//import { Inject, Injectable } from '@angular/core';
//import { HttpClient } from '@angular/common/http';
//import { Http } from '@angular/http';