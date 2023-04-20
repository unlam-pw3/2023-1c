using JuegoDeRol_PW3.Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeRol_PW3.Repositorio.Interfaces
{
    public interface IHeroRepositorio
    {
        void AgregarHeroe(Hero hero);
        void EliminarHeroe(int id);
        List<Hero> ListarHeroes();
        void ModificarHeroe(Hero heroModificado);
        List<Editorial> ObtenerEditoriales();
        Editorial ObtenerEditorialPorId(int editorial);
        Hero ObtenerHeroePorId(int idNum);
    }
}
