import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Usuario } from "../../modelo/usuario";

@Injectable({
  providedIn: "root"
})

export class UsuarioServico {

  private baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  public verificarUsuario(usuario: Usuario): Observable<Usuario> {

    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      email: usuario.email,
      senha: usuario.senha
    }

    //this.baseUrl = raiz do site que pode ser exemplo.: http://www.quickbuy.com/
    return this.http.post<Usuario>(this.baseUrl + "api/usuario", body, { headers });

  }

}

