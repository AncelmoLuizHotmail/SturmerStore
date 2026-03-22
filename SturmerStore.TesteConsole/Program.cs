// See https://aka.ms/new-console-template for more information
using SturmerStore.Domain.Entities;
using SturmerStore.Domain.Enums;
using SturmerStore.TesteConsole.Services;

//SERVICOS
var produtoService = new ProdutoService();
var clienteService = new ClienteService();
var pedidoService = new PedidoService();

Console.WriteLine("LOJA DO BRENO");

// Criando os produtos
produtoService.CriarProdutos();

// Criando o cliente
var cliente = clienteService.CriarCliente();

// Criando o pedido
pedidoService.CriarPedido(cliente);

Console.WriteLine();

char resposta;
do
{
    Console.Write("Digite o código do produto: ");
    var codigoProduto = int.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade: ");
    var quantidade = int.Parse(Console.ReadLine());

    var produtoSelecionado = produtoService.BuscarPorId(codigoProduto);

    if (produtoSelecionado == null || quantidade < 1)
    {
        Console.WriteLine("Produto não encontrado ou Quantidade inválida. \n Tente novamente.");
    }
    else
    {
        pedidoService.AdicionarItem(produtoSelecionado, quantidade);
    }

    Console.Write("Deseja adicionar mais itens? (S/N)");
    resposta = char.Parse(Console.ReadLine());
    Console.WriteLine();
} while (resposta == 'S' || resposta == 's');


//Exibir os itens do pedido
pedidoService.ExibirResumo();

Console.WriteLine();
Console.WriteLine("Deseja remover algum item? (S/N)");
var respostaRemover = char.Parse(Console.ReadLine());

while (respostaRemover == 'S' || respostaRemover == 's')
{
    Console.Write("Digite o código do produto que deseja remover: ");
    var codigoProdutoRemover = int.Parse(Console.ReadLine());
    Console.Write("Digite a quantidade a retirar: ");
    var qtdRemover = int.Parse(Console.ReadLine());

    pedidoService.DiminuirQuantidadeItem(codigoProdutoRemover, qtdRemover);

    Console.Write("Deseja remover mais algum item? (S/N)");
    respostaRemover = char.Parse(Console.ReadLine());
}

//Exibir os itens do pedido
pedidoService.ExibirResumo();

// Fechando o Pedido
pedidoService.Fechar();

//AGORA VAI PAGAR O PEDIDO

pedidoService.Pagar();







