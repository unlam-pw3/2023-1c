using Clase7.EF.IslaDelTesoro.Data.Entidades;

namespace Clase7.EF.IslaDelTesoro.Logica
{
    public interface ICategoriaTesoroServicio
    {
        List<CategoriaTesoro> ObtenerTodos();
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
            return _contexto.CategoriaTesoros.ToList();
        }
    }
    
}