using JuegoDeRol_PW3.Repositorio.Entidades;

namespace JuegoDeRol_PW3.Web.Models
{
    public class HeroEditorialesViewModel
    {
        public Hero heroe { get; set; }
        public IFormFile? imagen { get; set; }
        public List<Editorial>? editoriales { get; set; }
    }
}
