namespace SturmerStore.Domain.Entities
{
    public class ItemPedido : BaseEntity
    {
        public ItemPedido(int pedidoId, Produto produto, int quantidade)
        {
            PedidoId = pedidoId;
            ProdutoId = produto.Id;
            Quantidade = quantidade;

            Produto = produto;

            CalcularValorParcial();
        }


        public int PedidoId { get; private set; }
        public int ProdutoId { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorParcial { get; private set; }

        public Pedido Pedido { get; private set; }
        public Produto Produto { get; private set; }

        private void CalcularValorParcial()
        {
            ValorParcial = Produto.Preco * Quantidade;
        }
    }
}
