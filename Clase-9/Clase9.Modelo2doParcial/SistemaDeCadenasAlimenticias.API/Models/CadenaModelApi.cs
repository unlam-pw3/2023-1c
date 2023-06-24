using SistemaDeCadenasAlimenticias.Data.EF;
using System.Text.Json.Serialization;

namespace SistemaDeCadenasAlimenticias.API.Models
{
    public class CadenaModelApi
    {
        [JsonIgnore]
        public int IdCadena { get; set; }

            public string RazonSocialCadena { get; set; } = null!;

            //public virtual ICollection<Sucursal> Sucursals { get; set; } = new List<Sucursal>();
  
    }
}
