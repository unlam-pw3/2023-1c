using System.Data.Entity;
using Clase7.EF.IslaDelTesoro.Data.Entidades;

namespace Clase7.EF.IslaDelTesoro.Logica
{
    public interface ICategoriaTesoroServicio
    {
        List<CategoriaTesoro> ObtenerTodos();
        List<CategoriaTesoro> ObtenerFiltrado(int[] IdCategoriaTesoros);
        void Eliminar(int idCategoriaTesoro);
    }

    public class CategoriaTesoroServicio : ICategoriaTesoroServicio
    {
        private PW320231CEFIslaDelTesoroContext _contexto;
        public CategoriaTesoroServicio(PW320231CEFIslaDelTesoroContext context)
        {
            _contexto = context;
        }
        public List<CategoriaTesoro> ObtenerTodos()
        {
            return _contexto.CategoriaTesoros
                .OrderBy(c => c.Nombre)
                .ToList();
        }

        public List<CategoriaTesoro> ObtenerFiltrado(int[] IdCategoriaTesoros)
        {
            return _contexto.CategoriaTesoros
                .Where(ct => IdCategoriaTesoros.Contains(ct.IdCategoriaTesoro))
                .OrderBy(c => c.Nombre)
                .ToList();
        }

        public void Eliminar(int idCategoriaTesoro)
        {
            var categoriaTesoro = _contexto.CategoriaTesoros
                .Include(t=> t.IdTesoros)
                .FirstOrDefault(c=> c.IdCategoriaTesoro == idCategoriaTesoro);
            
            if (categoriaTesoro != null)
            {
                foreach (var tesoro in categoriaTesoro.IdTesoros)
                {
                    tesoro.IdCategoriaTesoros.Remove(categoriaTesoro);
                    //_contexto.Tesoros.Remove(tesoro);
                }

                _contexto.CategoriaTesoros.Remove(categoriaTesoro);
                _contexto.SaveChanges();
            }
        }
    }
    
}