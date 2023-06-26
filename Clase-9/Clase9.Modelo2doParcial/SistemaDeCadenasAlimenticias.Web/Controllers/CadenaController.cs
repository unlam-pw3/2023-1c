using Microsoft.AspNetCore.Mvc;
using SistemaDeCadenasAlimenticias.Web.CadenaApiCliente;
using SistemaDeCadenasAlimenticias.Web.Models;

namespace SistemaDeCadenasAlimenticias.Web.Controllers
{
    public class CadenaController : Controller
    {

        private ICadenaApiCliente _cadenaApiCliente;
        public CadenaController(ICadenaApiCliente cadenaApiCliente) {
            _cadenaApiCliente = cadenaApiCliente;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<IActionResult> Index()
        {
           CadenaIndexViewModel vm = new CadenaIndexViewModel();
            vm.listaDeCadenas = await _cadenaApiCliente.ObtenerCadenas();
            return View(vm);
        }
    }
}
