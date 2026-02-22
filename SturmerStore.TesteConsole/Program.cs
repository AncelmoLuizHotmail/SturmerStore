// See https://aka.ms/new-console-template for more information
using SturmerStore.Domain.Entities;
using SturmerStore.Domain.Enums;

Console.WriteLine("LOJA DO BRENO");

var xBacon = new Produto();
var xSalada = new Produto();
var cocaCola = new Produto();

xBacon.Id = 1;
xBacon.Nome = "X-Bacon";
xBacon.Descricao = "Hambúrguer com bacon, queijo, alface e tomate";
xBacon.Preco = 15.00m;
xBacon.Tipo = TipoProdutoEnum.Sanduiche;
xBacon.DataInclusao = DateTime.Now;

xSalada.Id = 2;
xSalada.Nome = "X-Salada";
xSalada.Descricao = "Hambúrguer com queijo, alface, tomate e maionese";
xSalada.Preco = 12.00m;
xSalada.Tipo = TipoProdutoEnum.Sanduiche;
xSalada.DataInclusao = DateTime.Now;

cocaCola.Id = 3;
cocaCola.Nome = "Coca-Cola";
cocaCola.Descricao = "Refrigerante de cola";
cocaCola.Preco = 5.00m;
cocaCola.Tipo = TipoProdutoEnum.Bebida;

Console.WriteLine($"Sanduiche: {xBacon.Nome} - Preço: R${xBacon.Preco}");
Console.WriteLine($"Sanduiche: {xSalada.Nome} - Preço: R${xSalada.Preco}");
Console.WriteLine($"Bebida: {cocaCola.Nome} - Preço: R${cocaCola.Preco}");
