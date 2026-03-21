// See https://aka.ms/new-console-template for more information
using SturmerStore.Domain.Entities;
using SturmerStore.Domain.Enums;

Console.WriteLine("LOJA DO BRENO");

var xBacon = new Produto(1, "X-Bacon", "Hambúrguer com bacon, queijo", 15.00m, TipoProdutoEnum.Sanduiche, 10);
var xSalada = new Produto(2, "X-Salada", "Hambúrguer com prezunto, queijo, alface e tomate", 15.00m, TipoProdutoEnum.Sanduiche, 10);
var cocaCola = new Produto(3, "Coca-Cola", "Coca-Zero", 5.00m, TipoProdutoEnum.Bebida, 20);

var listaProdutos = new List<Produto>();
listaProdutos.Add(xBacon);
listaProdutos.Add(xSalada);
listaProdutos.Add(cocaCola);

Console.WriteLine("PRODUTOS DISPONÍVEIS");
foreach (var item in listaProdutos)
{
    Console.WriteLine($@"Codigo: {item.Id} - {item.Nome} - {item.Tipo} - R${item.Preco} Qtd no Estoque: {item.QuantidadeEstoque}");
}

var clienteBreno = new Cliente(1,
                                "Breno Sturmer",
                                "123.456.789-00",
                                "(11) 99999-9999",
                                "breno@gmail.com",
                                "rua tal", 1);

var pedido = new Pedido(1, clienteBreno.Id, DateTime.Now, StatusPedidoEnum.Aberto);

Console.WriteLine();

char resposta;

do
{
    Console.Write("Digite o código do produto: ");
    var codigoProduto = int.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade: ");
    var quantidade = int.Parse(Console.ReadLine());

    var produtoSelecionado = listaProdutos.FirstOrDefault(p => p.Id == codigoProduto);

    if (produtoSelecionado == null || quantidade < 1)
    {
        Console.WriteLine("Produto não encontrado ou Quantidade inválida. \n Tente novamente.");
    }
    else 
    {
        pedido.AdicionarItem(produtoSelecionado, quantidade);
    }

    Console.Write("Deseja adicionar mais itens? (S/N)");
    resposta = char.Parse(Console.ReadLine());
    Console.WriteLine();
} while (resposta == 'S' || resposta == 's');


Console.WriteLine("COMANDA DO PEDIDO");
foreach (var item in pedido.Itens)
{
    Console.WriteLine($@"Produto: {item.Produto.Nome} - Preço: R${item.Produto.Preco} - Quantidade: {item.Quantidade} - Valor: R${item.ValorParcial}");
}

Console.WriteLine($"Valor Total do Pedido: R${pedido.ValorTotal}");

Console.WriteLine("Deseja remover algum item? (S/N)");
var respostaRemover = char.Parse(Console.ReadLine());

while (respostaRemover == 'S' || respostaRemover == 's')
{
    Console.Write("Digite o código do produto que deseja remover: ");
    var codigoProdutoRemover = int.Parse(Console.ReadLine());
    pedido.RemoverItem(codigoProdutoRemover);

    Console.Write("Deseja remover mais algum item? (S/N)");
    respostaRemover = char.Parse(Console.ReadLine());
}

Console.WriteLine($"Valor Total do Pedido: R${pedido.ValorTotal}");

//Console.WriteLine();

//Console.WriteLine($"Status do Pedido: {pedido.Status}");
//pedido.FecharPedido();
//Console.WriteLine("Agora o pedido foi fechado!");
//Console.WriteLine($"Status do Pedido: {pedido.Status}");

//AGORA VAI PAGAR O PEDIDO



//Console.WriteLine();

//Console.WriteLine($@"Sanduiche: {xBacon.Nome} 
//                     Preço: R${xBacon.Preco} 
//                     Qtd no Estoque: {xBacon.QuantidadeEstoque} 
//                     Data Cadastro: {xBacon.DataInclusao}");

//Console.WriteLine($@"Sanduiche: {xSalada.Nome} 
//                     Preço: R${xSalada.Preco} 
//                     Qtd no Estoque: {xSalada.QuantidadeEstoque}
//                     Data Cadastro: {xBacon.DataInclusao}");

//Console.WriteLine($@"Bebida: {cocaCola.Nome} 
//                     Preço: R${cocaCola.Preco} 
//                     Qtd no Estoque: {cocaCola.QuantidadeEstoque}
//                     Data Cadastro: {xBacon.DataInclusao}");

//Console.WriteLine();

//xBacon.DebitarEstoque(5);

//Console.WriteLine($@"Sanduiche: {xBacon.Nome} 
//                    Preço: R${xBacon.Preco} 
//                    Qtd no Estoque: {xBacon.QuantidadeEstoque}
//                    Data Cadastro: {xBacon.DataInclusao}
//                    Data Atualização:{xBacon.DataAlteracao} ");

//xBacon.ReporEstoque(15);

//Console.WriteLine($"Sanduiche: {xBacon.Nome} - Preço: R${xBacon.Preco} - Qtd no Estoque: {xBacon.QuantidadeEstoque}");




