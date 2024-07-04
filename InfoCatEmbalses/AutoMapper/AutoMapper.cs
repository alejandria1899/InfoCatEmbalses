using AutoMapper;
using InfoCatEmbalses.Embalses;

namespace InfoCatEmbalses.AutoMapper;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<Embalse, EmbalseDto>();
        CreateMap<EmbalseCreateDto, Embalse>();
    }
    
}