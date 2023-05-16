using Clase3.MVC.Dominio.Entidades;

namespace Clase3.MVC.Web.Models
{
    public class ClassViewModel
    {
        public Poder poder { get; set; }
        public List<TipoPoder> tipoPoder { get; set; }

        public List<Poder> poderes { get; set; }
    }
}
