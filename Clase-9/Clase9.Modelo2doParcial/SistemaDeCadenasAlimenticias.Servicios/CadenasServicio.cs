using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeCadenasAlimenticias.Data.EF;

namespace SistemaDeCadenasAlimenticias.Servicios;

public interface ICadenasServicio
{
    List<Cadena> Listar();
}
public class CadenasServicio : ICadenasServicio
{
    private Pw320231cModelo2doParcialContext _contexto;

    public CadenasServicio(Pw320231cModelo2doParcialContext contexto)
    {
        _contexto = contexto;
    }

    public List<Cadena> Listar()
    {
        return _contexto.Cadenas
            .OrderBy(c=> c.RazonSocial)
            .ToList();
    }
}

