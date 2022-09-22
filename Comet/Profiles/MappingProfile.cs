using AutoMapper;
using Comet.DTOs;
using Comet.Models;

namespace Comet.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeDto>()
                .ReverseMap();
            CreateMap<Model, ModelDto>()
                .ReverseMap();
            CreateMap<Feature, FeatureDto>()
                .ReverseMap();
        }
    }
}
