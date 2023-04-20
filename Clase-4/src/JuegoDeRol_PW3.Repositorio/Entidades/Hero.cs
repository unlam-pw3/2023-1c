using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeRol_PW3.Repositorio.Entidades
{
    public class Hero
    {
        public int? Id { get; set; }

        [Required (ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Creador es requerido")]
        [StringLength(maximumLength: 100,ErrorMessage = "No puede tener mas de 100 caracteres" )]
        public string Creador { get; set; }

        public DateOnly? FechaAlta { get; set; }

        [Required(ErrorMessage = "La descripcion es requerida")]
        public string Descripcion { get; set; }
        public string? Imagen { get; set; }

        [Required(ErrorMessage = "La Editorial es requerida")]
        public int Editorial { get; set; }
    }
}

