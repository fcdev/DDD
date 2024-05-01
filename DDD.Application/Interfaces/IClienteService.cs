using DDD.Application.Models;

namespace DDD.Application.Interfaces
{
    public interface IClienteService
    {
        void Criar(ClienteVM cliente);
        ClienteVM LerPorId(int id);
        IEnumerable<ClienteVM> LerTodos();
        void Atualizar(ClienteVM cliente);
        void Deleter(ClienteVM cliente);
    }
}
