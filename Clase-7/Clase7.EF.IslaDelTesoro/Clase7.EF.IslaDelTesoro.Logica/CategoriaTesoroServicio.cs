using Clase7.EF.IslaDelTesoro.Data.Entidades;

namespace Clase7.EF.IslaDelTesoro.Logica
{
    public interface ICategoriaTesoroServicio
    {
        List<CategoriaTesoro> ObtenerTodos();
        List<CategoriaTesoro> ObtenerFiltrado(int[] IdCategoriaTesoros);
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
    }
    
}