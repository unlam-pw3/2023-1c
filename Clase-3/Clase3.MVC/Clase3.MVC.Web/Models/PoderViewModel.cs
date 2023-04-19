using Clase3.MVC.Dominio.Entidades;

namespace Clase3.MVC.Web.Models
{
    public class PoderViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TipoPoder Tipo { get; set; }
        public int Daño { get; set; }
        public List<TipoPoder> Tipos { get; set; }
    }
}
