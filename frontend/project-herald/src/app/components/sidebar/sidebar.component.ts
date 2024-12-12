import {Component} from '@angular/core';
import { NavigationComponent } from "../navigation/navigation.component";
import { SelectorComponent } from "../selector/selector.component";

@Component({
  selector: 'app-sidebar',
  standalone: true,
  imports: [NavigationComponent, SelectorComponent],
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.css'
})
export class SidebarComponent {
  isSitemapVisible: boolean = false;
  isSelectorVisible: boolean = false;
  toggleSelector() {
    this.isSelectorVisible = !this.isSelectorVisible;
  }
  toggleSitemap() {
    this.isSitemapVisible = !this.isSitemapVisible;
  }
}
