import { ProdutoService } from 'src/app/services/produto.service';
import { Component, OnInit } from '@angular/core';
import { Produto } from 'src/app/models/produto';
import { Router } from '@angular/router';

@Component({
    selector: 'app-cadastrar-produto',
    templateUrl: './cadastrar-produto.component.html',
    styleUrls: ['./cadastrar-produto.component.css']
})
export class CadastrarProdutoComponent implements OnInit {

    nome!: string;

    constructor(private service: ProdutoService,private router: Router) {}

    ngOnInit(): void {}

    create(): void{
        let produto : Produto = {
            nome: this.nome,
        }
        this.service.create(produto).subscribe((produto) => {
            this.router.navigate(["produto/listar"])
        })
    }

}
