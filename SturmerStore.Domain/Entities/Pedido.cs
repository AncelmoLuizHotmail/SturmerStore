using SturmerStore.Domain.Enums;

namespace SturmerStore.Domain.Entities
{
    public class Pedido : BaseEntity
    {
        public Pedido(int id, 
            int clienteId, 
            DateTime dataCadastro, 
            StatusPedidoEnum status, 
            decimal valorTotal)
        {
            Id = id;
            ClienteId = clienteId;
            DataCadastro = dataCadastro;
            Status = status;
            ValorTotal = valorTotal;
        }

        public int ClienteId { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public StatusPedidoEnum Status { get; private set; }
        public decimal ValorTotal { get; private set; }

        public Cliente Cliente { get; private set; }
    }
}
