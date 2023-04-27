using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.MVC.Dominio.Entidades
{
    public class Poder
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual TipoPoder Tipo { get; set; }

        public int idTipo { get; set; }
        public int Daño { get; set; }
    }
}
