using System;
using System.Collections.Generic;

namespace Clase7.EF.IslaDelTesoro.Data.Entidades
{
    public partial class Ubicacion
    {
        public Ubicacion()
        {
            Tesoros = new HashSet<Tesoro>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int? CoordenadaX { get; set; }
        public int? CoordenadaY { get; set; }
        public int? CoordenadaRadio { get; set; }
        public string? ImagenUrl { get; set; }

        public virtual ICollection<Tesoro> Tesoros { get; set; }
    }
}
