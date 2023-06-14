using System.Drawing;
using Clase8.Jugueteria.Logica.Entidades;

namespace Clase8.Jugueteria.Logica
{
    public interface IJuguetesLogica
    {
        List<JugueteEntidad> ObtenerJuguetes();
        JugueteEntidad ObtenerJuguete(int id);
        void CrearJuguete(JugueteEntidad juguete);
        void ActualizarJuguete(JugueteEntidad juguete);
        void EliminarJuguete(int id);
    }

    public class JuguetesLogica : IJuguetesLogica
    {

        private static List<JugueteEntidad> Items { get; set; } = new List<JugueteEntidad>()
        { 
            //cargar Items iniciales de ejemplo
            new JugueteEntidad()
            {
                IdJuguete = 1,
                Nombre = "Pelota",
                Desc = "Nro 5",
                Precio = 100,
                EdadMin = 5,
                FechaCreacion = new DateTime(2021, 06, 14, 19, 39, 0),
                FechaModificacion = null
            },
            new JugueteEntidad()
            {
                IdJuguete = 2,
                Nombre = "Monopatin",
                Desc = "Plegable",
                Precio = 1000,
                EdadMin = 2,
                FechaCreacion = new DateTime(2023, 06, 14, 19, 39, 0),
                FechaModificacion = null
            },
            new JugueteEntidad()
            {
                IdJuguete = 3,
                Nombre = "Monopoly",
                Desc = "De 2 a 4 jugadores",
                Precio = 500,
                EdadMin = 7,
                FechaCreacion = new DateTime(2020, 06, 14, 19, 39, 0),
                FechaModificacion = null
            } 
        };

        public List<JugueteEntidad> ObtenerJuguetes()
        {
            return Items;
        }

        public JugueteEntidad ObtenerJuguete(int id)
        {
            return Items.Find(x => x.IdJuguete == id);
        }

        public void CrearJuguete(JugueteEntidad juguete)
        {
            //juguete.FechaCreacion = DateTime.Now; //2023-06-14 19:39:00 (Arg -03)
            juguete.FechaCreacion = DateTime.UtcNow; //2023-06-14 22:39:00 (UTC 0)
            Items.Add(juguete);
        }

        public void ActualizarJuguete(JugueteEntidad juguete)
        {
            var item = Items.Find(x => x.IdJuguete == juguete.IdJuguete);
            if (item == null)
                return;
            
            item.Nombre = juguete.Nombre;
            item.Desc = juguete.Desc;
            item.Precio = juguete.Precio;
            item.EdadMin = juguete.EdadMin;
            item.FechaModificacion = DateTime.UtcNow;
        }

        public void EliminarJuguete(int id)
        {
            var item = Items.Find(x => x.IdJuguete == id);
            if (item != null)
            {
                Items.Remove(item);
            }
        }
    }

}