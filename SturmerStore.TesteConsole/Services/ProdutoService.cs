using SturmerStore.Domain.Entities;
using SturmerStore.TesteConsole.Factories;

namespace SturmerStore.TesteConsole.Services
{
    public class ProdutoService
    {
       
        private List<Produto> _produtos;

        public void CriarProdutos()
        {
            _produtos = DadosFakeFactory.CriarProdutos();

            ExibirProdutos(_produtos);
        }

        public void ExibirProdutos(List<Produto> produtos)
        {
            Console.WriteLine("PRODUTOS DISPONÍVEIS");
            foreach (var item in produtos)
            {
                Console.WriteLine($@"Codigo: {item.Id} - {item.Nome} - {item.Tipo} - R${item.Preco} Qtd no Estoque: {item.QuantidadeEstoque}");
            }
        }

        public Produto BuscarPorId(int produtoId)
        {
            var produto = _produtos.FirstOrDefault(p => p.Id == produtoId);

            return produto;
        }
    }
}
