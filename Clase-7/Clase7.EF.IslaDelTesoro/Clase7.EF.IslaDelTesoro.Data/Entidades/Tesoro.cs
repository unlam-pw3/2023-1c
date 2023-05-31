using System;
using System.Collections.Generic;

namespace Clase7.EF.IslaDelTesoro.Data.Entidades
{
    public partial class Tesoro
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? ImagenUrl { get; set; }
        public decimal? Valor { get; set; }
        public int? IdUbicacion { get; set; }

        public virtual Ubicacion? IdUbicacionNavigation { get; set; }
    }
}
