using SturmerStore.Domain.Entities;
using SturmerStore.Domain.Enums;

namespace SturmerStore.TesteConsole.Factories
{
    public static class DadosFakeFactory
    {
        public static List<Produto> CriarProdutos()
        {
            var listaProdutos = new List<Produto>();

            var xBacon = new Produto(1, "X-Bacon", "Hambúrguer com bacon, queijo", 15.00m, TipoProdutoEnum.Sanduiche, 10);
            var xSalada = new Produto(2, "X-Salada", "Hambúrguer com prezunto, queijo, alface e tomate", 15.00m, TipoProdutoEnum.Sanduiche, 10);
            var cocaCola = new Produto(3, "Coca-Cola", "Coca-Zero", 5.00m, TipoProdutoEnum.Bebida, 20);

            listaProdutos.Add(xBacon);
            listaProdutos.Add(xSalada);
            listaProdutos.Add(cocaCola);

            return listaProdutos;
        }

        public static Cliente CriarCliente()
        {
            var cliente = new Cliente(1,
                                "Breno Sturmer",
                                "123.456.789-00",
                                "(11) 99999-9999",
                                "breno@gmail.com",
                                "rua tal", 1);

            return cliente;
        }
    }
}
