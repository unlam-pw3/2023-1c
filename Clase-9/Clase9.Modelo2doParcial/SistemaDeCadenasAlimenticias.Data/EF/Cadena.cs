using System;
using System.Collections.Generic;

namespace SistemaDeCadenasAlimenticias.Data.EF;

public partial class Cadena
{
    public int Id { get; set; }

    public string RazonSocial { get; set; } = null!;

    public virtual ICollection<Sucursal> Sucursals { get; set; } = new List<Sucursal>();
}
