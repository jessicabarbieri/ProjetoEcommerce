"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var LojaCarrinhoComprasComponent = /** @class */ (function () {
    function LojaCarrinhoComprasComponent() {
        this.produtos = [];
    }
    LojaCarrinhoComprasComponent.prototype.adicionar = function (produto) {
        var produtoLocaStorage = localStorage.getItem("produtoLocaStorage");
        if (!produtoLocaStorage) {
            // se nao existir nada dentro do localStorage
            this.produtos.push(produto);
        }
        else {
            // se ja existir pelo menos um unico item armazenado na sessao(localLocalStorage)
            this.produtos = JSON.parse(produtoLocaStorage);
            this.produtos.push(produto);
        }
        localStorage.setItem("produtoLocaStorage", JSON.stringify(this.produtos));
    };
    LojaCarrinhoComprasComponent.prototype.obterProdutos = function () {
        var produtoLocaStorage = localStorage.getItem("produtoLocaStorage");
        if (produtoLocaStorage)
            return JSON.parse(produtoLocaStorage);
        return this.produtos;
    };
    LojaCarrinhoComprasComponent.prototype.removerProduto = function (produto) {
        var produtoLocaStorage = localStorage.getItem("produtoLocaStorage");
        if (produtoLocaStorage) {
            this.produtos = JSON.parse(produtoLocaStorage);
            this.produtos = this.produtos.filter(function (p) { return p.id != produto.id; });
            localStorage.setItem("produtoLocaStorage", JSON.stringify(this.produtos));
        }
    };
    LojaCarrinhoComprasComponent.prototype.atualizar = function (produtos) {
        localStorage.setItem("produtoLocaStorage", JSON.stringify(produtos));
    };
    LojaCarrinhoComprasComponent.prototype.temItensCarrinhoCompras = function () {
        var itens = this.obterProdutos();
        return (itens.length > 0);
    };
    LojaCarrinhoComprasComponent.prototype.limparCarrinhoCompras = function () {
        localStorage.setItem("produtoLocaStorage", "");
    };
    return LojaCarrinhoComprasComponent;
}());
exports.LojaCarrinhoComprasComponent = LojaCarrinhoComprasComponent;
//# sourceMappingURL=loja.carrinho.compras.component.js.map