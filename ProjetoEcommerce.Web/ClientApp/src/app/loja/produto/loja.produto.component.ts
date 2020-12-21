import { Component, OnInit } from "@angular/core";
import { ProdutoServico } from "../../servicos/produto/produto.servico";
import { Produto } from "../../modelo/produto";
import { Router } from "@angular/router";
import { LojaCarrinhoComprasComponent } from "../carrinho-compras/loja.carrinho.compras.component";

@Component({
  selector: "loja-app-produto",
  templateUrl: "./loja.produto.component.html",
  styleUrls: ["./loja.produto.component.css"]
})

export class LojaProdutoComponent implements OnInit {
  public produto: Produto;
  public carrinhoCompras: LojaCarrinhoComprasComponent;

  ngOnInit(): void {

    this.carrinhoCompras = new LojaCarrinhoComprasComponent();
    var produtoDetalhe = sessionStorage.getItem('produtoDetalhe');
    if (produtoDetalhe) {
      this.produto = JSON.parse(produtoDetalhe);
    }
  }

  constructor(private produtoServico: ProdutoServico, private router: Router) {

  }

  public comprar() {
    this.carrinhoCompras.adicionar(this.produto);
    this.router.navigate(["/loja-efetivar"]);
  }

}
