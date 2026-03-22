using SturmerStore.Domain.Entities;

namespace SturmerStore.TesteConsole.Services
{
    public class PedidoService
    {
        private Pedido _pedido;

        public void CriarPedido(Cliente cliente)
        {
            var novoPedido = new Pedido(1, cliente.Id, DateTime.Now, Domain.Enums.StatusPedidoEnum.Aberto);

            _pedido = novoPedido;
        }

        public void AdicionarItem(Produto produto, int quantidade)
        {
            _pedido.AdicionarItem(produto, quantidade);
        }

        public void ExibirResumo()
        {
            Console.WriteLine();
            Console.WriteLine("COMANDA DO PEDIDO");

            foreach (var item in _pedido.Itens)
            {
                Console.WriteLine($@"Produto: {item.Produto.Nome} - Preço: R${item.Produto.Preco} - Quantidade: {item.Quantidade} - Valor: R${item.ValorParcial}");
            }

            Console.WriteLine();
            Console.WriteLine($"Valor Total do Pedido: R${_pedido.ValorTotal}");
        }

        public void DiminuirQuantidadeItem(int produtoId, int quantidade)
        {
            _pedido.DiminuirQuantidadeItem(produtoId, quantidade);
        }

        public void Fechar() 
        { 
            _pedido.Fechar();

            Console.WriteLine($"Status do Pedido: {_pedido.Status}");
            Console.WriteLine();
        }

        public void Pagar()
        {
            _pedido.Pagar();

            Console.WriteLine($"Status do Pedido: {_pedido.Status}");
            Console.WriteLine();
        }

        public void Cancelar()
        {
            _pedido.Cancelar();

            Console.WriteLine($"Status do Pedido: {_pedido.Status}");
            Console.WriteLine();
        }
    }
}
