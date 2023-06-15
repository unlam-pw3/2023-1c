using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8.Jugueteria.Logica.Entidades
{
    public class JugueteEntidad
    {
        public int IdJuguete { get; set; }
        public string Nombre { get; set; }
        public string? Desc { get; set; }
        public decimal Precio { get; set; }
        public int EdadMin { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
