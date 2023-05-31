using Clase7.EF.IslaDelTesoro.Data.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Clase7.EF.IslaDelTesoro.Web.Controllers
{
    public class UbicacionController : Controller
    {
        private PW320231CEFIslaDelTesoroContext _context;

        public UbicacionController(PW320231CEFIslaDelTesoroContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var ubicaciones = _context.Ubicacions.ToList();
            return View(ubicaciones);
        }
       

        public IActionResult Crear()
        {
            var NuevaUbicacion = new Ubicacion();
            return View(NuevaUbicacion);
        }

        [HttpPost]
        public IActionResult Crear(Ubicacion nuevaUbicacion)
        {
            if (ModelState.IsValid)
            {
            _context.Add(nuevaUbicacion);
            _context.SaveChanges();
            return RedirectToAction("Index");
            }
            return View(nuevaUbicacion);
        }

        public IActionResult Editar(int id)
        {
            var ubicacionencontrada = _context.Ubicacions.Find(id);
            if (ubicacionencontrada != null)
            {
                return View(ubicacionencontrada);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Editar(Ubicacion ubicacionActualizada)
        {
            if (ModelState.IsValid)
            {
                var ubicacionAActualizar=_context.Ubicacions.Find(ubicacionActualizada.Id);
                if (ubicacionAActualizar != null) {
                    ubicacionAActualizar.Nombre = ubicacionActualizada.Nombre;
                    _context.SaveChanges(); 
                    return RedirectToAction("Index");
                }  
            }
            return View(ubicacionActualizada);
        }

        public IActionResult Eliminar(int id)
        {

            var ubicacionARemover = _context.Ubicacions.Find(id);
            if (ubicacionARemover != null)
            {
                _context.Remove(ubicacionARemover);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
