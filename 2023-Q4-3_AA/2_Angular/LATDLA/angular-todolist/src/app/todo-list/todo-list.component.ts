import { Component, OnInit, OnDestroy } from '@angular/core';
import { NzMessageService } from 'ng-zorro-antd/message';
import { Observable, Subscription } from 'rxjs';
import { Todo } from '../models/Todo';
import { TodoListService } from './todo-list.service';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.scss']
})
export class TodoListComponent implements OnInit, OnDestroy {
  todos$!: Observable<Todo[]>;
  private subscriptions: Subscription[] = [];

  constructor(
    private todoListService: TodoListService,
    private nzMessageService: NzMessageService
  ) { }

  loadAll = () => {
    this.todos$ = this.todoListService.findAll();
    //this.todos$.subscribe(todos => console.log("Todos:", todos));
  }

  changeStatus(todo: Todo) {
    this.todoListService.update(todo)
      .subscribe(() => {
        this.todos$ = this.todoListService.findAll();
      });
    this.nzMessageService.info('Changed Status / Zmieniony Status');
  }

  deleteTodo(todo: Todo){
    this.todoListService.delete(todo.id)
      .subscribe(() => {
        this.todos$ = this.todoListService.findAll();
      });
    this.nzMessageService.warning('Todo Deleted / Zadanie Usunięte');
  }

  cancel(): void {
    this.nzMessageService.info('Cancelled... / Anulowane...');
  }

  ngOnInit(): void {
    this.loadAll();
  }
  
  refreshTodos = () => {
    this.loadAll();
  };
  
  ngOnDestroy(): void {
    this.subscriptions.forEach(sub => sub.unsubscribe());
  }

}
