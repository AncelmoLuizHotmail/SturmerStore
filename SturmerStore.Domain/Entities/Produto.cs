
using SturmerStore.Domain.Enums;

namespace SturmerStore.Domain.Entities
{
    public class Produto : BaseEntity
    {
       
        // Construtor vazio para permitir a criação de objetos sem parâmetros
        public Produto(int id, 
            string nome, 
            string descricao, 
            decimal preco, 
            TipoProdutoEnum tipoProduto, 
            int quantidadeEstoque) 
        { 
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Tipo = tipoProduto;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public string Nome { get; private set; }
        public TipoProdutoEnum Tipo { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public int QuantidadeEstoque { get; private set; }

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade > QuantidadeEstoque)
                throw new InvalidOperationException("Quantidade em estoque insuficiente.");

            QuantidadeEstoque -= quantidade; //decremento
            DataAlteracao = DateTime.Now.AddHours(1);
        }

        public void ReporEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade; //incremento
        }

    }
}

// POO tem quatro pilares: Encapsulamento, Herança, Polimorfismo e Abstração.
// S O L I D