using AutoMapper;
using Clase8.Jugueteria.Api.Models;
using Clase8.Jugueteria.Logica.Entidades;

namespace Clase8.Jugueteria.Api.Configuracion
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<JugueteEntidad, Juguete>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdJuguete))
            .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Desc))
            .ForMember(dest => dest.EdadMinima, opt => opt.MapFrom(src => src.EdadMin));
        }
    }
}
