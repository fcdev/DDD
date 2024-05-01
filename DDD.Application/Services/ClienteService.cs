using DDD.Application.Interfaces;
using DDD.Application.Mappings;
using DDD.Application.Models;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces;

namespace DDD.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Atualizar(ClienteVM cliente)
        {
            throw new NotImplementedException();
        }

        public void Criar(ClienteVM cliente)
        {
            throw new NotImplementedException();
        }

        public void Deleter(ClienteVM cliente)
        {
            throw new NotImplementedException();
        }

        public ClienteVM LerPorId(int id) => ClienteMapping.ToModel(_clienteRepository.LerPorId(id));

        public IEnumerable<ClienteVM> LerTodos() => ClienteMapping.ToModel(_clienteRepository.LerTodos());
    }
}
