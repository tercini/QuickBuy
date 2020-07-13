import { Component } from "@angular/core"

@Component({
  selector: "app-produto",
  template: "<html><body>{{ obterNome() }}</body></html>"
})
export class ProdutoComponent { // Nome das classes começando com maiúsculo por conta da convencao PascalCase

  /*camelCase para variáveis, atributos e nome das funções*/

  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return "Samsung ";
  }

}
