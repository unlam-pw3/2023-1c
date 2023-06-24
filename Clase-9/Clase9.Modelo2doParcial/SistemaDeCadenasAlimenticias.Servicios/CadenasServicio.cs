using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaDeCadenasAlimenticias.Data.EF;

namespace SistemaDeCadenasAlimenticias.Servicios;

public interface ICadenasServicio
{
    Cadena ActualizarCadena(Cadena cadenaEntidad);
    void CrearCadena(Cadena cadenaAdd);
    void EliminarCadena(int id);
    void EliminarCadenaInclude(int id);
    List<Cadena> Listar();
    Cadena ObtenerCadena(int id);
}
public class CadenasServicio : ICadenasServicio
{
    private Pw320231cModelo2doParcialContext _contexto;

    public CadenasServicio(Pw320231cModelo2doParcialContext contexto)
    {
        _contexto = contexto;
    }

    public void CrearCadena(Cadena cadenaAdd)
    {
        //juguete.IdJuguete = _contexto.Max(i => i.IdJuguete) + 1;
        _contexto.Add(cadenaAdd);
        _contexto.SaveChanges();
    }

    public List<Cadena> Listar()
    {
        return _contexto.Cadenas
            .OrderBy(c=> c.RazonSocial)
            .ToList();
    }

    public Cadena ObtenerCadena(int id)
    {
        return _contexto.Cadenas.Find(id); 
    }

    public void EliminarCadena(int id)
    {   var eliminarCadena= _contexto.Cadenas.Find(id);
      

        if (eliminarCadena != null)
        {
         
            var sucursalesAsociadas = _contexto.Sucursals.Where(s => s.IdCadena == id);
            foreach (var sucursal in sucursalesAsociadas)
            {
                // Por el modelo de dominio se debe eliminar la sucursal
                _contexto.Sucursals.Remove(sucursal);
                // Actualizar las sucursales asociadas estableciendo IdCadena en null
                //sucursal.IdCadena = null;
            }

            _contexto.Cadenas.Remove(eliminarCadena);
            _contexto.SaveChanges();
        }
    }

    public void EliminarCadenaInclude(int id)
    {
        var eliminarcadena = _contexto.Cadenas.Include(c => c.Sucursals).FirstOrDefault(c => c.Id == id);

        if (eliminarcadena != null)
        {
            foreach (var sucursal in eliminarcadena.Sucursals)
            {
                _contexto.Sucursals.Remove(sucursal);
            }
            _contexto.Cadenas.Remove(eliminarcadena);
            _contexto.SaveChanges();
        }

    }

    public Cadena ActualizarCadena(Cadena cadenaEntidad)
    {

        var actualizarCadena = _contexto.Cadenas.Find(cadenaEntidad.Id);

        if (actualizarCadena != null)
        {
            actualizarCadena.RazonSocial = cadenaEntidad.RazonSocial;
            _contexto.Cadenas.Update(actualizarCadena);
            _contexto.SaveChanges();
            return actualizarCadena;
        }
        return null;
    }
}

