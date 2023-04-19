using Clase3.MVC.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.MVC.Dominio.Logica
{
    public interface IPoderesRepositorio
    {
        int ObtenerProximoId();
        List<Entidades.Poder> ObtenerTodos();
        void Agregar(Entidades.Poder poder);//, Entidades.TipoPoder tipo);
        void Eliminar(int id);
        Poder ObtenerPoder(int? id);
        Poder ObtenerPoderPorNombre(string nombre);
        void Editar(Entidades.Poder poder);
        Poder Detalle(int? id);
       // TipoPoder ObtenerTipoPoderPorNombre(string nombreTipoPoder);
    }
    public class PoderesRepositorio : IPoderesRepositorio
    {
        private static List<Entidades.Poder> _poderes = new List<Entidades.Poder>();
        private static TipoPoderRepositorio _tipoPoderRepositorio;

        public PoderesRepositorio(ITipoPoderRepositorio tipoPoderRepositorio)
        {
            tipoPoderRepositorio = tipoPoderRepositorio;
            Inicializar();
        }

        public void Inicializar()
        {
            _poderes.Clear();
            _poderes.Add(new Entidades.Poder() { Id = 1, Nombre = "Rayo", Tipo = new Entidades.TipoPoder() { Id = 1, Nombre = "Ataque" }, Daño = 100 });
            _poderes.Add(new Entidades.Poder() { Id = 2, Nombre = "Lanza", Tipo = new Entidades.TipoPoder() { Id = 1, Nombre = "Ataque" }, Daño = 50 });
            _poderes.Add(new Entidades.Poder() { Id = 3, Nombre = "Escudo", Tipo = new Entidades.TipoPoder() { Id = 2, Nombre = "Defensa" }, Daño = 0 });
            _poderes.Add(new Entidades.Poder() { Id = 4, Nombre = "Curar", Tipo = new Entidades.TipoPoder() { Id = 3, Nombre = "Curacion" }, Daño = 0 });
        }

        public int ObtenerProximoId()
        {
            return _poderes.Count() + 1;
        }

        public List<Entidades.Poder> ObtenerTodos()
        {
            return _poderes;
        }

        public void Agregar(Entidades.Poder poder)//, Entidades.TipoPoder tipo)
        {
            poder.Nombre = poder.Nombre.Trim();

            if (_poderes.Any(tp => tp.Nombre.Equals(poder.Nombre, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException();
            }
            //ver un selector de tipo poder
            poder.Id = ObtenerProximoId();
            //List<Entidades.TipoPoder> poderitos = _tipoPoderRepositorio.ObtenerTodos().FirstOrDefault();
            // ObtenerTipoPoderPorNombre(tipo.);

            //_poderes.Add(poderitos);
            _poderes.Add(poder);
        }

        /*public List<TipoPoder> ObtenerTipoPoderPorNombre(string nombreTipoPoder)
        {
            // Aquí puedes implementar la lógica para obtener el tipo de poder por nombre
            // Por ejemplo, supongamos que tienes una lista de tipos de poder en tu repositorio
            // y quieres buscar el tipo de poder por su nombre en esa lista
            var tipoPoderEncontrado = _tipoPoderRepositorio.ObtenerTodos.FirstOrDefault(tp => tp.Nombre == nombreTipoPoder);
            return tipoPoderEncontrado;
        }*/
        public void Eliminar(int id)
        {
            var poder = _poderes.FirstOrDefault(x => x.Id == id);
            if (poder != null)
            {
                _poderes.Remove(poder);
            }
        }

        public Poder ObtenerPoder(int? id)
        {
            var poderId = id;
            var poderEncontrado = _poderes.Cast<Poder>().ToList().Find(item => item.Id == poderId);
            return poderEncontrado;
        }

        public Poder ObtenerPoderPorNombre(string nombre)
        {
            var poderEncontrado = _poderes.FirstOrDefault(item => item.Nombre == nombre);
            return poderEncontrado;
        }
        public void Editar(Poder poder)
        {
            var registro = _poderes.FirstOrDefault(m => m.Id == poder.Id);
            if (!string.IsNullOrEmpty(poder.Nombre))
            {
                registro.Nombre = poder.Nombre.Trim();
            }
            else
            {
                throw new ArgumentException("No es el mismo");
            }
        }

        public Poder Detalle(int? id)
        {
            return ObtenerPoder(id);
        }
    }
}
