using Microsoft.AspNetCore.Mvc;
using SistemaDeCadenasAlimenticias.Web.CadenaApiCliente;
using SistemaDeCadenasAlimenticias.Web.Models;
using System.Net;
using System.Net.Http;

namespace SistemaDeCadenasAlimenticias.Web.Controllers
{
    public class CadenaController : Controller
    {

        private ICadenaApiCliente _cadenaApiCliente;
        public CadenaController(ICadenaApiCliente cadenaApiCliente)
        {
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

        [HttpGet]
        public IActionResult CrearCadena()
        {
            CadenaApiModel cadena = new CadenaApiModel();
            return View(cadena);
        }

        [HttpPost]
        public async Task<IActionResult> CrearCadena(CadenaApiModel cadena)
        {
            HttpResponseMessage response = await _cadenaApiCliente.CrearCadena(cadena);
            if (response.IsSuccessStatusCode)
            {
                // La solicitud se realizó con éxito (código de estado 200, 201, etc.)
                // Aquí puedes realizar acciones adicionales si es necesario
                return RedirectToAction("Index");
            }


            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                // La solicitud fue incorrecta (código de estado 400)
                // Aquí puedes manejar el caso de una solicitud incorrecta
                return View(cadena);
            }
            return View();
        }
    }
}
