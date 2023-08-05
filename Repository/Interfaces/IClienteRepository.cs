using SenaiApp.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApp.Repository.Interfaces
{
    public interface IClienteRepository
    {
        List<Cliente> PegarTodosClientes();
        bool SalvarCliente(Cliente pessoaDTo);
        public bool DeletarPessoa(long id);
    }
}