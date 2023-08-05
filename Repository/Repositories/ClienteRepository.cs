using Microsoft.EntityFrameworkCore;
using SenaiApp.Domain.Entidade;
using SenaiApp.Repository.Contexts;
using SenaiApp.Repository.Interfaces;
using SenaiApp.Repository.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Repository.Repositorios
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(SenaiAppContext context) : base(context) { }

        public List<Cliente> PegarTodosClientes()
        {
            return GetAll().ToList();
        }

        public bool SalvarCliente(Cliente cliente)
        {
            try
            {
                Salvar(cliente);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeletarPessoa(long id)
        {
            try
            {
                Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}