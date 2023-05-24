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
    }
}
