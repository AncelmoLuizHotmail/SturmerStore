using System;
using System.Collections.Generic;
using System.Text;

namespace SturmerStore.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
