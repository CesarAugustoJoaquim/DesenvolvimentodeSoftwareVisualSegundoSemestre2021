import { CadastrarProdutoComponent } from './components/views/produto/cadastrar-produto/cadastrar-produto.component';
import { ListarProdutoComponent } from './components/views/produto/listar-produto/listar-produto.component';
import { Component } from '@angular/core';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    {
        path: "",
        component: ListarProdutoComponent
    },
    {
        path: "produto/listar",
        component: ListarProdutoComponent
    },
    {
        path: "produto/cadastrar",
        component: CadastrarProdutoComponent
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }