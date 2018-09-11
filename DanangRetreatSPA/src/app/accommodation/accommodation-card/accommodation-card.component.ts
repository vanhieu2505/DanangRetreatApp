import { Component, OnInit, Input } from '@angular/core';
import { Accommodation } from '../../_models/accommodation';

@Component({
  selector: 'app-accommodation-card',
  templateUrl: './accommodation-card.component.html',
  styleUrls: ['./accommodation-card.component.css']
})
export class AccommodationCardComponent implements OnInit {
  @Input() accomodation: Accommodation;

  constructor() { }

  ngOnInit() {
  }

}
