using Clase3.MVC.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.MVC.Dominio.Logica
{

    public interface ITipoPoderRepositorio
    {
        List<Entidades.TipoPoder> ObtenerTodos();
        void Agregar(Entidades.TipoPoder poder);
        void Eliminar(int id);
        void Editar(TipoPoder tipoPoder);
        TipoPoder ObtenerTipoPoder(int? id);
        TipoPoder Detalle(int? id);
        TipoPoder ObtenerTipoPoderPorNombre(string nombre);
    }
    public class TipoPoderRepositorio : ITipoPoderRepositorio
    {
        private static List<Entidades.TipoPoder> _tiposPoderes = new List<Entidades.TipoPoder>();

        public TipoPoderRepositorio()
        {
            Inicializar();
        }
        private void Inicializar()
        {
            _tiposPoderes.Clear();
            _tiposPoderes.Add(new Entidades.TipoPoder() { Id = 1, Nombre = "Ataque" });
            _tiposPoderes.Add(new Entidades.TipoPoder() { Id = 2, Nombre = "Defensa" });
            _tiposPoderes.Add(new Entidades.TipoPoder() { Id = 3, Nombre = "Curacion" });
        }

        private int ObtenerProxId()
        {
            return _tiposPoderes.Count() + 1;
        }

        public List<Entidades.TipoPoder> ObtenerTodos()
        {
            return _tiposPoderes;
        }

        public void Agregar(Entidades.TipoPoder tipoPoder)
        {
            tipoPoder.Nombre = tipoPoder.Nombre.Trim();

            if (_tiposPoderes.Any(tp => tp.Nombre.Equals(tipoPoder.Nombre, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException();
            }

            tipoPoder.Id = ObtenerProxId();

            _tiposPoderes.Add(tipoPoder);
        }

        public void Eliminar(int id)
        {
            var tipoPoder = _tiposPoderes.FirstOrDefault(x => x.Id == id);
            if (tipoPoder != null)
            {
                _tiposPoderes.Remove(tipoPoder);
            }
        }

        public TipoPoder ObtenerTipoPoder(int? id)
        {
            var tipoPoderId = id;
            var tipoPoderEncontrado = _tiposPoderes.Cast<TipoPoder>().ToList().Find(item => item.Id == tipoPoderId);
            return tipoPoderEncontrado;
        }

        public TipoPoder ObtenerTipoPoderPorNombre(string nombre)
        {
            var tipoPoderEncontrado = _tiposPoderes.FirstOrDefault(item => item.Nombre == nombre);
            return tipoPoderEncontrado;
        }
        public void Editar(TipoPoder tipoPoder)
        {
            var registro = _tiposPoderes.FirstOrDefault(m => m.Id == tipoPoder.Id);
            if (!string.IsNullOrEmpty(tipoPoder.Nombre))
            {
                registro.Nombre = tipoPoder.Nombre.Trim();
            }
            else
            {
                throw new ArgumentException("No es el mismo");
            }
        }

        public TipoPoder Detalle(int? id)
        {
            return ObtenerTipoPoder(id);
        }
    }
}
