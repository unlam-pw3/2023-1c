namespace Clase8.Jugueteria.MVC.ApiClients
{
    public class JugueteApiModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int EdadMinima { get; set; }
    }
}
