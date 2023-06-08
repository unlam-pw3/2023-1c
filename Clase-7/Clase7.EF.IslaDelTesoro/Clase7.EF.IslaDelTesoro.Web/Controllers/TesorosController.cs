using Clase7.EF.IslaDelTesoro.Data.Entidades;
using Clase7.EF.IslaDelTesoro.Logica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clase7.EF.IslaDelTesoro.Web.Controllers
{
    public class TesorosController : Controller
    {
        private PW320231CEFIslaDelTesoroContext _context;
        private ICategoriaTesoroServicio _categoriaTesoroServicio;
        
        public TesorosController(PW320231CEFIslaDelTesoroContext context,
            ICategoriaTesoroServicio categoriaTesoroServicio)
        {
            _context = context;
            _categoriaTesoroServicio = categoriaTesoroServicio;
        }
        public IActionResult Index()
        {
            var tesoros = _context.Tesoros.ToList();
            return View(tesoros);
        }

        public IActionResult Crear()
        {
            ViewBag.Ubicaciones = _context.Ubicacions
                   .OrderBy(o => o.Nombre)
                   .ToList();
            ViewBag.CategoriaTesoros = _categoriaTesoroServicio.ObtenerTodos();

            return View(new Tesoro());
        }

        [HttpPost]
        public IActionResult Crear(Tesoro tesoro, int[] IdCategoriaTesoros)
        {
            if (ModelState.IsValid)
            {
                tesoro.IdUbicacion = tesoro.IdUbicacion;
                tesoro.IdCategoriaTesoros = _categoriaTesoroServicio.ObtenerFiltrado(IdCategoriaTesoros);

                _context.Tesoros.Add(tesoro);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Ubicaciones = _context.Ubicacions
                   .OrderBy(o => o.Nombre)
                   .ToList();
            ViewBag.CategoriaTesoros = _categoriaTesoroServicio.ObtenerTodos();

            return View(tesoro);
        }

        public IActionResult Editar(int id)
        {
            var tesoro = _context.Tesoros
                    .Include(t => t.IdCategoriaTesoros)
                    .FirstOrDefault(t => t.Id == id);


            if (tesoro != null)
            {
                ViewBag.Ubicaciones = _context.Ubicacions
                    .OrderBy(o => o.Nombre)
                    .ToList();
                ViewBag.CategoriaTesoros = _categoriaTesoroServicio.ObtenerTodos();

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
        public IActionResult Editar(Tesoro tesoro, int[] IdCategoriaTesoros)
        {
            //Actualizando manualmente cada campo (es mas seguro)
            if (ModelState.IsValid)
            {
                var tesoroEnBD = _context.Tesoros
                    .Include(t => t.IdCategoriaTesoros)
                    .FirstOrDefault(t=> t.Id == tesoro.Id);

                if (tesoroEnBD == null)
                {
                    return View(tesoro);
                }

                tesoroEnBD.Nombre = tesoro.Nombre;
                tesoroEnBD.Descripcion = tesoro.Descripcion;
                tesoroEnBD.ImagenUrl = tesoro.ImagenUrl;
                tesoroEnBD.Valor = tesoro.Valor;
                tesoroEnBD.IdUbicacion = tesoro.IdUbicacion;

                // Actualizar las categorías de tesoro
                tesoroEnBD.IdCategoriaTesoros.Clear();

                foreach (var idCategoriaTesoro in IdCategoriaTesoros)
                {
                    var categoriaTesoro = _context.CategoriaTesoros.Find(idCategoriaTesoro);
                    if (categoriaTesoro != null)
                    {
                        tesoroEnBD.IdCategoriaTesoros.Add(categoriaTesoro);
                    }
                }

                _context.Update(tesoroEnBD);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            
            ViewBag.Ubicaciones = _context.Ubicacions
                .OrderBy(o=> o.Nombre)
                .ToList();

            ViewBag.CategoriaTesoros = _categoriaTesoroServicio.ObtenerTodos();

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
