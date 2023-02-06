import { Component } from '@angular/core';

@Component({
  selector: 'app-manager-footer',
  templateUrl: './manager-footer.component.html',
  styleUrls: ['./manager-footer.component.css']
})
export class ManagerFooterComponent {
  ngOnInit(): void {
  }
  scrollTop() {
    window.scroll({
      top: 0,
      left: 0,
      behavior: 'smooth'
    });

  }
}
