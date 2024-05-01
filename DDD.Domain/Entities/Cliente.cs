namespace DDD.Domain.Entities
{
    internal class Cliente
    {
        public Cliente(int clienteId, string nome, string sobrenome, string email, DateTime dataCadastro, bool ativo)
        {
            ClienteId = clienteId;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }

        public int ClienteId { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }
    }
}
