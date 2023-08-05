using Microsoft.AspNetCore.Mvc;
using SenaiApp.Domain.Entidade;
using Service.Interface;

namespace SenaiApp.Controllers
{
    public class ClienteController : Controller
    {
        //Constante para poder trabalhar com o cliente service
        private IClienteService _clienteService;

        //Construtor para usar injeção de dependencia
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {
            ViewBag.Cliente = _clienteService.BuscarTodos();
            return View();
        }

        public IActionResult Remover(Cliente model)
        {
            _clienteService.Delet(model.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Form()
        {
            var model = new Cliente();
            return View(model);
        }

        [HttpPost]
        public IActionResult Form(Cliente model)
        {
            var cliente = _clienteService.Salvar(model);
            return RedirectToAction("Index");
        }
    }
}
