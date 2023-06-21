using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaDeCadenasAlimenticias.Data.EF;

namespace SistemaDeCadenasAlimenticias.Servicios;

public interface ISucursalesServicio
{
    void Agregar(Sucursal sucursal);
    List<Sucursal> Listar();
}
public class SucursalesServicio : ISucursalesServicio
{
    private Pw320231cModelo2doParcialContext _contexto;
    public SucursalesServicio(Pw320231cModelo2doParcialContext contexto)
    {
        _contexto = contexto;
    }

    public void Agregar(Sucursal sucursal)
    {
        _contexto.Sucursals.Add(sucursal);
        _contexto.SaveChanges();
    }

    public List<Sucursal> Listar()
    {
        return _contexto.Sucursals
            .Include(s => s.IdCadenaNavigation)
            .ToList();
    }

    //public List<Sucursal> ObtenerPorCadena(int idCadena)
    //{
    //    using (var db = new Pw320231cModelo2doParcialContext())
    //    {
    //        return db.Sucursals.Where(s => s.IdCadena == idCadena).ToList();
    //    }
    //}
}

