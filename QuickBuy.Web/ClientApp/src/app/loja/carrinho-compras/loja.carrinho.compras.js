"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var LojaCarrinhoCompras = /** @class */ (function () {
    function LojaCarrinhoCompras() {
        this.produtos = [];
    }
    LojaCarrinhoCompras.prototype.adicionar = function (produto) {
        var produtoLocaStorage = localStorage.getItem("produtoLocaStorage");
        if (!produtoLocaStorage) {
            // se nao existir nada dentro do localStorage
            this.produtos.push(produto);
        }
        else {
            // se ja existir pelo menos um unico item armazenado na sessao (localStorage)
            this.produtos = JSON.parse(produtoLocaStorage);
            this.produtos.push(produto);
        }
        localStorage.setItem("produtoLocaStorage", JSON.stringify(this.produtos));
    };
    LojaCarrinhoCompras.prototype.obterProdutos = function () {
        var produtoLocaStorage = localStorage.getItem("produtoLocaStorage");
        if (produtoLocaStorage)
            return JSON.parse(produtoLocaStorage);
    };
    LojaCarrinhoCompras.prototype.removerProduto = function (produto) {
        var produtoLocaStorage = localStorage.getItem("produtoLocaStorage");
        if (produtoLocaStorage) {
            this.produtos = JSON.parse(produtoLocaStorage);
            this.produtos = this.produtos.filter(function (p) { return p.id != produto.id; });
            localStorage.setItem("produtoLocaStorage", JSON.stringify(this.produtos));
        }
    };
    LojaCarrinhoCompras.prototype.atualizar = function (produtos) {
        localStorage.setItem("produtoLocaStorage", JSON.stringify(produtos));
    };
    return LojaCarrinhoCompras;
}());
exports.LojaCarrinhoCompras = LojaCarrinhoCompras;
//# sourceMappingURL=loja.carrinho.compras.js.map