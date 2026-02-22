
using SturmerStore.Domain.Enums;

namespace SturmerStore.Domain.Entities
{
    public class Produto : BaseEntity
    {
        public string Nome { get; set; }
        public TipoProdutoEnum Tipo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Status { get; set; }
    }
}
