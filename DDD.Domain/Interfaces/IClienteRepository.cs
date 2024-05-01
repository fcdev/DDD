using DDD.Domain.Entities;

namespace DDD.Domain.Interfaces
{
    public interface IClienteRepository
    {
        void Criar(Cliente cliente);
        Cliente LerPorId(int id);
        IEnumerable<Cliente> LerTodos();
        void Atualizar(Cliente cliente);
        void Deleter(Cliente cliente);
    }
}
