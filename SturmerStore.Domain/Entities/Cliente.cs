namespace SturmerStore.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public Cliente(int id, 
            string nome,
            string cpf,
            string telefone,
            string email,
            string endereco,
            int status)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            Status = status;
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Endereco { get; private set; }
        public int Status { get; private set; }

        public List<Pedido> Pedidos { get; private set; }
    }
}
