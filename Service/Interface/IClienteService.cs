using SenaiApp.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IClienteService
    {
        List<Cliente> BuscarTodos();
        bool Salvar(Cliente cliente);
        public bool Delet(long id);
    }
}
