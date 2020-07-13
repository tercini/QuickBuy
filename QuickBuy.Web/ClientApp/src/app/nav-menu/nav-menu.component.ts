import { Component } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  public usuarioLogado(): boolean {
    var usuarioLogado = sessionStorage.getItem("usuario-autenticado");
    if (usuarioLogado == "1") {
      return true
    }
    return false;
  }

  sair() {
    //sessionStorage.setItem("usuario-autenticado");
  }
}
