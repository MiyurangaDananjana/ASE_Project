import { Component, OnInit, Inject } from '@angular/core';
import { DOCUMENT } from '@angular/common'
import { AuthService } from 'src/app/Service/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-manager-header',
  templateUrl: './manager-header.component.html',
  styleUrls: ['./manager-header.component.css']
})
export class ManagerHeaderComponent {

  constructor(@Inject(DOCUMENT) private document: Document, private authService: AuthService, private router:Router) { }

  ngOnInit(): void {
  }

  logout() {
    this.authService.removeToken();
    this.router.navigateByUrl('/home');
  }
  sidebarToggle() {
    //toggle sidebar function
    this.document.body.classList.toggle('toggle-sidebar');
  }
}
