using AutoMapper;
using MagicVillaApı.Models.Dto;
using MagicVillaApı.Models;

namespace MagicVillaApı
{
    public class MappingConfig : Profile
    {
            public MappingConfig()
            {
                CreateMap<Villa, VillaDTO>();
                CreateMap<VillaDTO, Villa>();

                CreateMap<Villa, VillaCreateDTO>().ReverseMap();
                CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
            }
    }
}
