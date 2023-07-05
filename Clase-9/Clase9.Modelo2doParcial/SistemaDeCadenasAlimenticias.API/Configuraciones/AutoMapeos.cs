using AutoMapper;
using SistemaDeCadenasAlimenticias.API.Models;
using SistemaDeCadenasAlimenticias.Data.EF;

namespace SistemaDeCadenasAlimenticias.API.Configuraciones
{
    public class AutoMapeos:Profile
    {
        public AutoMapeos()
        {
            CreateMap<Cadena,CadenaModelApi>()
                .ForMember(dest => dest.IdCadena, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.RazonSocialCadena, opt => opt.MapFrom(src => src.RazonSocial))
            .ReverseMap();
        }
    }
}
