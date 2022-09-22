using AutoMapper;
using Comet.DTOs;
using Comet.Models;

namespace Comet.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeDto>().ReverseMap();
            CreateMap<Model, ModelDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();

            CreateMap<VehicleDto, Vehicle>()
                .ForMember(v => v.ContactName, opt => opt.MapFrom(vdto => vdto.Contact.Name))
                .ForMember(v => v.ContactEmail, opt => opt.MapFrom(vdto => vdto.Contact.Email))
                .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vdto => vdto.Contact.Phone))
                .ForMember(v => v.Features, opt => opt.MapFrom(vdto => vdto.Features.Select(id => new VehicleFeature { FeatureId = id })));
        }
    }
}
