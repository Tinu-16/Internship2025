import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Table } from './table/table';
import { Google } from './google/google';
import { List } from './list/list';
import { NestedList } from './nested-list/nested-list';
import { Alert } from './alert/alert';
import { LeapYear } from './leap-year/leap-year';


@Component({
  selector: 'app-root',
  imports: [RouterOutlet,Table, Google,List,NestedList,Alert,LeapYear],
  templateUrl: './app.html',
  styleUrls: ['./app.scss']
})
export class App {
  protected readonly title = signal('AngularAssignment1');
}
