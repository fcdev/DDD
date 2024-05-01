using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Interfaces
{
    internal interface IClienteRepository
    {
        void Criar(Cliente cliente);
        Cliente LerPorId(int id);
        IEnumerable<Cliente> LerTodos();
        void Atualizar(Cliente cliente);
        void Deleter(Cliente cliente);
    }
}
