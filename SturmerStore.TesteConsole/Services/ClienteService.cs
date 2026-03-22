using SturmerStore.Domain.Entities;
using SturmerStore.TesteConsole.Factories;

namespace SturmerStore.TesteConsole.Services
{
    public class ClienteService
    {
        public Cliente CriarCliente()
        {
            return DadosFakeFactory.CriarCliente();
        }
    }
}
