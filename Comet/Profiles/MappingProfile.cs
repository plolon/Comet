using AutoMapper;
using Comet.DTOs;
using Comet.DTOs.Vehicle;
using Comet.Models;

namespace Comet.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeDto>().ReverseMap();
            CreateMap<Make, KeyValuePairDto>().ReverseMap();
            CreateMap<Model, KeyValuePairDto>().ReverseMap();
            CreateMap<Feature, KeyValuePairDto>().ReverseMap();
        }
    }
}
