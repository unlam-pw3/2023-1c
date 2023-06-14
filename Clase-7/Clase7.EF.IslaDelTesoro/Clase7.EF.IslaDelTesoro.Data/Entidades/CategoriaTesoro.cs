using System;
using System.Collections.Generic;

namespace Clase7.EF.IslaDelTesoro.Data.Entidades
{
    public partial class CategoriaTesoro
    {
        public CategoriaTesoro()
        {
            IdTesoros = new HashSet<Tesoro>();
        }

        public int IdCategoriaTesoro { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Tesoro> IdTesoros { get; set; }
    }
}
