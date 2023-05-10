using Clase6.PasajeDeDatos.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase6.PasajeDeDatos.Web.Controllers
{
    public class EstadiosController : Controller
    {
        public IActionResult Index()
        {
            var estadioSudamericanos = new List<EstadioViewModel>()
            {
                new EstadioViewModel()
                {
                    Id = 1,
                    Nombre = "Mâs Monumental",
                    urlImagenEstadio = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/54/RiverPlateStadium.jpg/273px-RiverPlateStadium.jpg",
                    SeleccionPerteneciente = new SeleccionViewModel()
                    {
                        Id = 1,
                        Nombre = "Argentina"
                    }
    },
                new EstadioViewModel()
                {
                    Id = 2,
                    Nombre = "Monumental U Marathon",
                    urlImagenEstadio = "https://upload.wikimedia.org/wikipedia/commons/c/c4/Estadio_Monumental_2021.jpg",
                 SeleccionPerteneciente = new SeleccionViewModel()
                
                },
                new EstadioViewModel()
                {
                    Id = 3,
                    Nombre = "Maracaná",
                    urlImagenEstadio = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Vis%C3%A3o_do_torcedor.JPG/800px-Vis%C3%A3o_do_torcedor.JPG",
                  SeleccionPerteneciente = new SeleccionViewModel()
                },
            
    
            };

            return View(estadioSudamericanos);
        }
    }
}
