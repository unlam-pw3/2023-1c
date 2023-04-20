using JuegoDeRol_PW3.Repositorio.Entidades;
using JuegoDeRol_PW3.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeRol_PW3.Repositorio
{
    public class HeroRepositorio : IHeroRepositorio
    {
        public void AgregarHeroe(Hero hero)
        {
            int? idUltimo = ObtenerUltimoId();
            idUltimo++;

            hero.Id= idUltimo;
            hero.FechaAlta = DateOnly.FromDateTime(DateTime.Now);
            HeroPseudoDatabase.GetHeroes().Add(hero);

        }

        private int? ObtenerUltimoId()
        {
            int? ultimo = HeroPseudoDatabase.GetHeroes().LastOrDefault().Id;
            return ultimo;
        }

        public List<Hero> ListarHeroes()
        {
            return HeroPseudoDatabase.GetHeroes();
        }

        public Editorial ObtenerEditorialPorId(int editorial)
        {
            return EditorialPseudoDatabase.GetEditoriales().SingleOrDefault(e => e.Id == editorial);
        }

        public Hero ObtenerHeroePorId(int idNum)
        {
            return HeroPseudoDatabase.GetHeroes().FirstOrDefault(h => h.Id == idNum);
        }

        public List<Editorial> ObtenerEditoriales()
        {
            return EditorialPseudoDatabase.GetEditoriales();
        }

        public void ModificarHeroe(Hero heroModificado)
        {
            Hero heroe = HeroPseudoDatabase.GetHeroes().Find(h => h.Id == heroModificado.Id);

            heroe.Descripcion = heroModificado.Descripcion;
            heroe.Nombre = heroModificado.Nombre;
            heroe.Creador = heroModificado.Creador;

        }

        public void EliminarHeroe(int id)
        {
            Hero hero = ObtenerHeroePorId(id);
            HeroPseudoDatabase.GetHeroes().Remove(hero);
        }
    }
}
