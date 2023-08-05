using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
