using DDD.Application.Models;
using DDD.Domain.Entities;

namespace DDD.Application.Mappings
{
    public static class ClienteMapping
    {
        public static Cliente ToDomain(this ClienteVM clienteVM)
        {
            return new Cliente(clienteVM.ClienteId, clienteVM.Nome, clienteVM.Sobrenome, clienteVM.Email, clienteVM.DataCadastro, clienteVM.Ativo);
        }

        public static ClienteVM ToModel(this Cliente cliente)
        {
            return new ClienteVM(cliente.ClienteId, cliente.Nome, cliente.Sobrenome, cliente.Email, cliente.DataCadastro, cliente.Ativo);
        }

        public static IEnumerable<Cliente> ToDomain(IEnumerable<ClienteVM> enumerable)
        {
            return new List<Cliente>(enumerable.Select(ToDomain));
        }

        public static IEnumerable<ClienteVM> ToModel(IEnumerable<Cliente> enumerable)
        {
            return new List<ClienteVM>(enumerable.Select(ToModel));
        }
    }
}
