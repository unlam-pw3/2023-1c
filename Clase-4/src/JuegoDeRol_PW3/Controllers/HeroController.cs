using JuegoDeRol_PW3.Repositorio.Entidades;
using JuegoDeRol_PW3.Servicio.Interfaces;
using JuegoDeRol_PW3.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace JuegoDeRol_PW3.Web.Controllers
{
    public class HeroController : Controller
    {

        readonly IHeroServicio _servicio;

        public HeroController(IHeroServicio servicio) {
            _servicio = servicio;
        }

        public IActionResult Listar()
        {
            List<Hero> heores = _servicio.ListarHeroes();
            return View(heores);
        }

        public IActionResult Detalle(int id) {

            
            Hero heroe = _servicio.ObtenerHeroePorId(id);
            Editorial editorial = _servicio.ObtenerEditorialPorId(heroe.Editorial);

            //Estos dos objetos no se pueden enviar a la vista, solo se envía un objeto
            //O se utiliza ViewBag o ViewData. No se recomienda hacer abuso de esto, lo 
            //mas recomendable es utilizar un ViewModel. (COMO UNA BOLSA DE OBJETOS QUE PASO A LA VISTA)

            HeroEditorialViewModel heroEditorialViewModel = new HeroEditorialViewModel();
            heroEditorialViewModel.heroe = heroe;
            heroEditorialViewModel.editorial = editorial;

            return View(heroEditorialViewModel);
        }


        public IActionResult Agregar()
        {
           List<Editorial> editoriales =  _servicio.ObtenerEditoriales();
           HeroEditorialesViewModel heroEditorialesViewModel = new HeroEditorialesViewModel();
           heroEditorialesViewModel.editoriales = editoriales;
           return View(heroEditorialesViewModel);
        }

        [HttpPost]
        public IActionResult Agregar(HeroEditorialesViewModel hero)
        {
            if (ModelState.IsValid)
            {
                string path = Path.Combine("wwwroot/", hero.imagen.FileName);

                var stream = new FileStream(path, FileMode.Create);
                hero.imagen.CopyTo(stream);

                Hero heroeNuevo = hero.heroe;
                heroeNuevo.Imagen = @"\" + hero.imagen.FileName;

                _servicio.AgregarHeroe(heroeNuevo);

                return Redirect("/Hero/Listar");

            }
            else {
                ViewBag.Error = "Ocurrió un error";
                return Redirect("/Hero/Listar");
            }


        }

        public IActionResult Modificar(int id) {
            Hero heroe = _servicio.ObtenerHeroePorId(id);
            Editorial editorial = _servicio.ObtenerEditorialPorId(heroe.Editorial);

            //Estos dos objetos no se pueden enviar a la vista, solo se envía un objeto
            //O se utiliza ViewBag o ViewData. No se recomienda hacer abuso de esto, lo 
            //mas recomendable es utilizar un ViewModel. (COMO UNA BOLSA DE OBJETOS QUE PASO A LA VISTA)

            HeroEditorialViewModel heroEditorialViewModel = new HeroEditorialViewModel();
            heroEditorialViewModel.heroe = heroe;
            heroEditorialViewModel.editorial = editorial;

            return View(heroEditorialViewModel);
        }
        [HttpPost]
        public IActionResult Modificar(IFormCollection formulario) {

            Hero HeroModificado = new Hero();

            HeroModificado.Id = int.Parse(formulario["Id"]);
            HeroModificado.Nombre = formulario["Nombre"];
            HeroModificado.Creador = formulario["Creador"];
            HeroModificado.Descripcion = formulario["Descripcion"];

            _servicio.ModificarHeroe(HeroModificado);

            return Redirect($"/Hero/Detalle/{formulario["Id"]}");
        }

        public IActionResult Eliminar(int id) {
            _servicio.EliminarHeroe(id);

            return Redirect("/Hero/Listar");
        }
    }


}
