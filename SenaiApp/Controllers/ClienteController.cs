using Microsoft.AspNetCore.Mvc;
using SenaiApp.Domain.Entidade;

namespace SenaiApp.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            var model = new Cliente();
            return View(model);
        }
    }
}
