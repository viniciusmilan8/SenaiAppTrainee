using AutoMapper;
using SenaiApi.Repository.Repositorios;
using SenaiApp.Domain.Entidade;
using SenaiApp.Repository.Interfaces;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<Cliente> BuscarTodos()
        {
            return _clienteRepository.PegarTodosClientes();
        }

        public bool Delet(long id)
        {
            return _clienteRepository.DeletarPessoa(id);
        }

        public bool Salvar(Cliente cliente) { 
            return _clienteRepository.SalvarCliente(cliente);
        }
    }
}
