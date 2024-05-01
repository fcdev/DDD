using DDD.Domain.Entities;
using DDD.Domain.Interfaces;

namespace DDD.Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        // TODO: Implementar a lógica de acesso a dados
        private List<Cliente> _clientes { get; }

        public ClienteRepository() 
        {
            _clientes =
            [
                new Cliente(1, "João", "Silva", "joao.silva@gmail.com", DateTime.Now.AddSeconds(-1), true),
                new Cliente(2, "Maria", "Santos", "maria.santos@gmail.com", DateTime.Now.AddSeconds(-4), true),
            ];
        }

        public void Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Criar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Deleter(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente LerPorId(int id) => _clientes.Find(c => c.ClienteId == id);

        public IEnumerable<Cliente> LerTodos() => _clientes.ToList();

    }
}
