using System.Diagnostics;
using Clase8.Jugueteria.MVC.ApiClients;
using Clase8.Jugueteria.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase8.Jugueteria.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IJuguetesApiClient _juguetesApiClient;

        public HomeController(ILogger<HomeController> logger, IJuguetesApiClient juguetesApiClient)
        {
            _logger = logger;
            _juguetesApiClient = juguetesApiClient;
        }

        public async Task<IActionResult> Index()
        {
            HomeIndexViewModel vm = new HomeIndexViewModel();
            vm.Juguetes = await _juguetesApiClient.ObtenerJuguetes();
            return View(vm);
        }


        public async Task<IActionResult> BuscarbyId(int id)
        {
            HomeIndexViewModel vm = new HomeIndexViewModel();
            vm.Juguetes = await _juguetesApiClient.ObtenerJuguetes();
            vm.Juguete = await _juguetesApiClient.ObtenerJuguete(id);
            return View("Index",vm);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}