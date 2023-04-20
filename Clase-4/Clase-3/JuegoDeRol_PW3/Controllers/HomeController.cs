using Microsoft.AspNetCore.Mvc;

namespace JuegoDeRol_PW3.Controllers
{
    public class HomeController : Controller
    {

    
        public IActionResult Index()
        {
            return View();
        }

       

    }
}