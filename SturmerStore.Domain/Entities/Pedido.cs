using SturmerStore.Domain.Enums;

namespace SturmerStore.Domain.Entities
{
    public class Pedido : BaseEntity
    {
        public Pedido(int id,
            int clienteId,
            DateTime dataCadastro,
            StatusPedidoEnum status)
        {
            Id = id;
            ClienteId = clienteId;
            DataCadastro = dataCadastro;
            Status = status;

            Itens = new List<ItemPedido>();
        }

        public int ClienteId { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public StatusPedidoEnum Status { get; private set; }
        public decimal ValorTotal { get; private set; }

        public Cliente Cliente { get; private set; }
        public List<ItemPedido> Itens { get; private set; }

        public void AdicionarItem(Produto produto, int quantidade)
        {
            var itemExistente = Itens.FirstOrDefault(i => i.ProdutoId == produto.Id);

            if (itemExistente != null)
            {
                itemExistente.SomarQuantidade(quantidade);
            }
            else
            {
                var novoItem = new ItemPedido(Id, produto, quantidade);
                Itens.Add(novoItem);
            }

            CalcularValorTotal();
        }

        public void DiminuirQuantidadeItem(int produtoId, int quantidade)
        {
            var item = Itens.FirstOrDefault(i => i.ProdutoId == produtoId);

            if (item == null)
                throw new InvalidOperationException("Item não encontrado");

            var novaQuantidade = item.Quantidade - quantidade;

            if(novaQuantidade < 0)
                throw new InvalidOperationException("Quantidade a remover acima da quantidade atual");

            if (novaQuantidade == 0)
            {
                Itens.Remove(item);
            }
            else
            {
                item.AtualizarQuantidade(novaQuantidade);
            }

            CalcularValorTotal();
        }

        private void CalcularValorTotal()
        {
            ValorTotal = Itens.Sum(i => i.ValorParcial);
        }

        public void FecharPedido()
        {
            if (Itens.Count == 0)
                throw new InvalidOperationException("Não é possível fechar um pedido sem itens.");

            Status = StatusPedidoEnum.Fechado;
        }

        public void PagarPedido()
        {

        }
    }
}
