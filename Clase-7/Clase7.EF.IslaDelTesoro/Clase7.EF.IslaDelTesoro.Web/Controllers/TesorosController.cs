using Clase7.EF.IslaDelTesoro.Data.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Clase7.EF.IslaDelTesoro.Web.Controllers
{
    public class TesorosController : Controller
    {
        private PW320231CEFIslaDelTesoroContext _context;
        public TesorosController(PW320231CEFIslaDelTesoroContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var tesoros = _context.Tesoros.ToList();
            return View(tesoros);
        }

        public IActionResult Crear()
        {
            return View(new Tesoro());
        }

        [HttpPost]
        public IActionResult Crear(Tesoro tesoro)
        {
            if (ModelState.IsValid)
            {
                _context.Tesoros.Add(tesoro);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tesoro);
        }

        public IActionResult Editar(int id)
        {
            var tesoro = _context.Tesoros.Find(id);
            if (tesoro != null)
            {
                return View(tesoro);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar2(Tesoro tesoro)
        {
            if (ModelState.IsValid)
            {
                _context.Tesoros.Update(tesoro);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tesoro);
        }
        
        [HttpPost]
        public IActionResult Editar(Tesoro tesoro)
        {
            //Actualizando manualmente cada campo (es mas seguro)
            if (ModelState.IsValid)
            {
                var tesoroEnBD = _context.Tesoros.Find(tesoro.Id);
                if (tesoroEnBD == null)
                {
                    return View(tesoro);
                }

                tesoroEnBD.Nombre = tesoro.Nombre;
                tesoroEnBD.Descripcion = tesoro.Descripcion;
                tesoroEnBD.ImagenUrl = tesoro.ImagenUrl;
                tesoroEnBD.Ubicacion = tesoro.Ubicacion;
                tesoroEnBD.Valor = tesoro.Valor;

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tesoro);

        }

        public IActionResult Eliminar(int id)
        {
            var tesoro = _context.Tesoros.Find(id);
            if (tesoro != null)
            {
                _context.Tesoros.Remove(tesoro);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
