using SistemaDeCadenasAlimenticias.Data.EF;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeCadenasAlimenticias.Web.Models
{


    [MetadataType(typeof(SucursalModelMetaData))]
    public partial class Sucursal
    {
        // Aquí no se agrega ninguna implementación, solo se vincula con la clase ModelMetaData
    }

    public class SucursalModelMetaData
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Direccion { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Ciudad { get; set; } = null!;

    }

}
