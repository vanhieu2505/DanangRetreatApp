import { Component, OnInit } from '@angular/core';
import { Accommodation } from '../../_models/accommodation';

@Component({
  selector: 'app-accommodation-landing',
  templateUrl: './accommodation-landing.component.html',
  styleUrls: ['./accommodation-landing.component.css']
})
export class AccommodationLandingComponent implements OnInit {
  featuredList: Accommodation[];
  today: Date;
  fromDate: Date;
  toDate: Date;
  numberOfGuests: number;

  constructor() { }

  ngOnInit() {
    this.today = new Date();
    this.numberOfGuests = 2;
  }

}
