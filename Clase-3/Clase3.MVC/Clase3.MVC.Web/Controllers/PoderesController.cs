using Clase3.MVC.Dominio.Entidades;
using Clase3.MVC.Dominio.Logica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Clase3.MVC.Web.Controllers
{
    public class PoderesController : Controller
    {
        IPoderesRepositorio _poderRepositorio;
        ITipoPoderRepositorio _tipoPoderesR;
        public PoderesController(IPoderesRepositorio poderesRepositorio,ITipoPoderRepositorio tipoPoderesRepositori) {
            _poderRepositorio = poderesRepositorio;
            _tipoPoderesR=tipoPoderesRepositori;
        }

        // GET: PoderesController
        public IActionResult Index()
        {
            var poderes = _poderRepositorio.ObtenerTodos();
            return View(poderes);
        }

        [HttpGet]
        public ActionResult Agregar()
        {
     var tipos = _tipoPoderesR.ObtenerTodos(); 
            //ViewBag.Tipos = new SelectList(tipos, "Id", "Nombre");
            ViewBag.Tipo = tipos.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Nombre }).ToList();
       
         

            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Poder poderes)
        {
            try
            {
                var tipo = ViewBag.Tipos as IEnumerable<TipoPoder>;
                poderes.Tipo = tipo.FirstOrDefault(t => t.Id == poderes.Tipo.Id);
                _poderRepositorio.Agregar(poderes);
            }
            catch (ArgumentException ex)
            {
                ViewBag.Mensaje = $"El nombre de poder {poderes.Nombre} ya existe";
                return View(poderes);
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                return View(poderes);
            }

            return RedirectToAction("Index");
        }

        // GET: PoderesController/Details/5
        public ActionResult Detalles(int id)
        {
           
          var poder = _poderRepositorio.buscarPorID(id);
            return View(poder);
        }

        // GET: PoderesController/Create
        public ActionResult Create()
        {
            return View();
        }


        // GET: PoderesController/Delete/5
        public ActionResult eliminar(int id)
        {
            _poderRepositorio.Eliminar(id);
            return RedirectToAction("Index");
        }

     
     
        
    
    }
}
