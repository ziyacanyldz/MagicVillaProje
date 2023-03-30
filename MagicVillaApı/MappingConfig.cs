using AutoMapper;

namespace MagicVillaApı
{
    public class MappingConfig : Profile
    {
        CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
        CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
    }
}
