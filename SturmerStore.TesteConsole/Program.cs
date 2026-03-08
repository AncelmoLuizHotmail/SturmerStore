// See https://aka.ms/new-console-template for more information
using SturmerStore.Domain.Entities;
using SturmerStore.Domain.Enums;

Console.WriteLine("LOJA DO BRENO");

var xBacon = new Produto(1, "X-Bacon", "Hambúrguer com bacon, queijo",15.00m,TipoProdutoEnum.Sanduiche, 10);
var xSalada = new Produto(2,"X-Salada","Hambúrguer com prezunto, queijo, alface e tomate", 15.00m, TipoProdutoEnum.Sanduiche, 10);
var cocaCola = new Produto(3, "Coca-Cola", "Coca-Zero", 5.00m, TipoProdutoEnum.Bebida, 20);

Console.WriteLine();

Console.WriteLine($@"Sanduiche: {xBacon.Nome} 
                     Preço: R${xBacon.Preco} 
                     Qtd no Estoque: {xBacon.QuantidadeEstoque} 
                     Data Cadastro: {xBacon.DataInclusao}");

Console.WriteLine($@"Sanduiche: {xSalada.Nome} 
                     Preço: R${xSalada.Preco} 
                     Qtd no Estoque: {xSalada.QuantidadeEstoque}
                     Data Cadastro: {xBacon.DataInclusao}");

Console.WriteLine($@"Bebida: {cocaCola.Nome} 
                     Preço: R${cocaCola.Preco} 
                     Qtd no Estoque: {cocaCola.QuantidadeEstoque}
                     Data Cadastro: {xBacon.DataInclusao}");

Console.WriteLine();

xBacon.DebitarEstoque(5);

Console.WriteLine($@"Sanduiche: {xBacon.Nome} 
                    Preço: R${xBacon.Preco} 
                    Qtd no Estoque: {xBacon.QuantidadeEstoque}
                    Data Cadastro: {xBacon.DataInclusao}
                    Data Atualização:{xBacon.DataAlteracao} ");

xBacon.ReporEstoque(15);

Console.WriteLine($"Sanduiche: {xBacon.Nome} - Preço: R${xBacon.Preco} - Qtd no Estoque: {xBacon.QuantidadeEstoque}");




