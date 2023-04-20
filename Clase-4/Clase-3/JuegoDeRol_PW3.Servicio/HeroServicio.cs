using JuegoDeRol_PW3.Repositorio.Entidades;
using JuegoDeRol_PW3.Repositorio.Interfaces;
using JuegoDeRol_PW3.Servicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeRol_PW3.Servicio
{
    public class HeroServicio : IHeroServicio
    {
        readonly IHeroRepositorio _repositorio;

        public HeroServicio (IHeroRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void AgregarHeroe(Hero hero)
        {
            _repositorio.AgregarHeroe(hero);
        }

        public void EliminarHeroe(int id)
        {
            _repositorio.EliminarHeroe(id);
        }

        public List<Hero> ListarHeroes()
        {
            return _repositorio.ListarHeroes();
        }

        public void ModificarHeroe(Hero heroModificado)
        {
            _repositorio.ModificarHeroe(heroModificado);
        }

        public List<Editorial> ObtenerEditoriales()
        {
            return _repositorio.ObtenerEditoriales();
        }

        public Editorial ObtenerEditorialPorId(int editorial)
        {
            return _repositorio.ObtenerEditorialPorId(editorial);
        }

        public Hero ObtenerHeroePorId(int idNum)
        {
           return _repositorio.ObtenerHeroePorId(idNum);
        }
    }
}
