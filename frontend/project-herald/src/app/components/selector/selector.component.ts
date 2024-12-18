import {ChangeDetectionStrategy, Component} from '@angular/core';
import { FormsModule } from '@angular/forms';
import {MatNativeDateModule, NativeDateAdapter} from '@angular/material/core';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatFormFieldModule} from '@angular/material/form-field';

@Component({
  selector: 'app-selector',
  providers: [NativeDateAdapter],
  imports: [MatDatepickerModule, MatFormFieldModule, MatNativeDateModule, FormsModule],
  changeDetection: ChangeDetectionStrategy.OnPush,
  standalone: true,
  templateUrl: './selector.component.html',
  styleUrl: './selector.component.css'
})
export class SelectorComponent {
  picker: any;

  genres = [
    {name: 'Opera', selected: false},
    {name: 'Symphony', selected: false},
    {name: 'Concerto', selected: false},
  ]

  periods = [
    {name: 'Baroque', selected: false},
    {name: 'Classical', selected: false},
    {name: 'Romantic', selected: false},
    {name: 'Late Romantic', selected: false},
    {name: '20th Century', selected: false},
    {name: '21st Century', selected: false},
  ]

  onGenreCheckboxChange(event: any, genre: any){
    genre.selected = event.target.checked;
  }

  onPeriodCheckboxChange(event: any, period: any){
    period.selected = event.target.checked;
  }
}
