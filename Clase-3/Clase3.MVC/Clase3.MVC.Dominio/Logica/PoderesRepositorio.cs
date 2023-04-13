using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.MVC.Dominio.Logica
{
    public interface IPoderesRepositorio
    {
        List<Entidades.Poder> ObtenerTodos();
        void Agregar(Entidades.Poder poder);
        void Eliminar(int id);
    }
    public class PoderesRepositorio : IPoderesRepositorio
    {
        private static List<Entidades.Poder> _poderes = new List<Entidades.Poder>();


        //public void Inicializar()
        //{
        //    _poderes.Clear();
        //    _poderes.Add(new Entidades.Poder() { Id = 1, Nombre = "Rayo", Tipo = new Entidades.TipoPoder() { Id = 1, Nombre = "Ataque" }, Daño = 100 });
        //    _poderes.Add(new Entidades.Poder() { Id = 2, Nombre = "Lanza", Tipo = new Entidades.TipoPoder() { Id = 1, Nombre = "Ataque" }, Daño = 50 });
        //    _poderes.Add(new Entidades.Poder() { Id = 3, Nombre = "Escudo", Tipo = new Entidades.TipoPoder() { Id = 2, Nombre = "Defensa" }, Daño = 0 });
        //    _poderes.Add(new Entidades.Poder() { Id = 4, Nombre = "Curar", Tipo = new Entidades.TipoPoder() { Id = 3, Nombre = "Curacion" }, Daño = 0 });
        //}
        public List<Entidades.Poder> ObtenerTodos()
        {
            return _poderes;
        }

        public void Agregar(Entidades.Poder poder)
        {
            _poderes.Add(poder);
        }

        public void Eliminar(int id)
        {
            var poder = _poderes.FirstOrDefault(x => x.Id == id);
            if (poder != null)
            {
                _poderes.Remove(poder);
            }
        }
    }
}
