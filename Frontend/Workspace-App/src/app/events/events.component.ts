import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

import { Event } from './event';
import { Response } from '../../utils/response'

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {

  public events!: Event[];
  public filteredEvents!: Event[];
  private _filter!: string;

  public get listFilter() : string {
    return this._filter;
  }

  public set listFilter(value: string) {
    this._filter = value;
    this.filteredEvents = this.listFilter ? this.filterEvents(this.listFilter) : this.events;
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEvents();
  }

  public getEvents() {
    this.http.get<Response<Event>>("https://localhost:5001/api/event").subscribe((response) => {
      this.events = response.data;
      this.filteredEvents = this.events;
    });
  }

  private filterEvents(filter: string) : Event[] {
    filter = filter.toLocaleLowerCase();
    return this.events.filter(event =>
      event.title.toLocaleLowerCase().indexOf(filter) !== -1 ||
      event.local.toLocaleLowerCase().indexOf(filter) !== -1
    );
  }

}
