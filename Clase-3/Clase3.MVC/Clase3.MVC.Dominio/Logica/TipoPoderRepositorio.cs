using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.MVC.Dominio.Logica
{

    public interface ITipoPoderRepositorio
    {
        List<Entidades.TipoPoder> ObtenerTodos();
        void Agregar(Entidades.TipoPoder poder);
        void Eliminar(int id);
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

        public List<Entidades.TipoPoder> ObtenerTodos()
        {
            return _tiposPoderes;
        }

        public void Agregar(Entidades.TipoPoder tipoPoder)
        {
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
    }
}
