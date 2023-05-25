namespace Clase6.PasajeDeDatos.Web.Models
{
    public class EstadioViewModel
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? urlImagenEstadio{ get; set; }
       
        public SeleccionViewModel? SeleccionPerteneciente { get; set; }
    }
}
