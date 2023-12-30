import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Todo } from '../models/Todo';

//@Injectable()
@Injectable({
  providedIn: 'root'
})

export class TodoListService {
  private resourceUrl = 'https://localhost:7284/api/todos';

  constructor(private http: HttpClient) { }

  create(todo: Todo): Observable<Todo> {
    const copy = this.convert(todo);
    return this.http.post<Todo>(this.resourceUrl, copy);
  }

  update(todo: Todo): Observable<Todo> {
    const copy = this.convert(todo);
    return this.http.put<Todo>(`${this.resourceUrl}/${copy.id}`, copy);
  }

  find(Id: number): Observable<Todo> {
    return this.http.get<Todo>(`${this.resourceUrl}/${Id}`);
  }

  findAll(): Observable<Todo[]> {
    return this.http.get<Todo[]>(this.resourceUrl);
  }

  delete(Id?: number | undefined): Observable<HttpResponse<any>> {
    return this.http.delete<any>(`${this.resourceUrl}/${Id}`);
  }

  private convert(todo: Todo): Todo {
    const copy: Todo = Object.assign({}, todo);
    return copy;
  }
}