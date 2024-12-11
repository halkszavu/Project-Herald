import {ChangeDetectionStrategy, Component} from '@angular/core';
import {MatNativeDateModule, NativeDateAdapter} from '@angular/material/core';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatFormFieldModule} from '@angular/material/form-field';

@Component({
  selector: 'app-sidebar',
  standalone: true,
  providers: [NativeDateAdapter],
  imports: [MatDatepickerModule, MatFormFieldModule, MatNativeDateModule],
  changeDetection: ChangeDetectionStrategy.OnPush,
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css'
})
export class SidebarComponent {

}
