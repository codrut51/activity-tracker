using System;
using Activity.Data.Create;
using Activity.Data.Read;
using Activity.Models;
using AutoMapper;
using System.Linq;

namespace Activity.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ActivityModel, ActivityDto>();
            CreateMap<UsersModel, UserDto>();
            CreateMap<ActivityCreateDto, ActivityModel>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.User, opt => opt.Ignore())
            .ForMember(dest => dest.Title, opt => opt.MapFrom(q => q.Title))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(q => q.Description))
            .ForMember(dest => dest.CreatedOn, opt => opt.UseDestinationValue())
            .ForMember(dest => dest.LastModified, opt => opt.UseDestinationValue());
            CreateMap<ActivityModel, ActivityModel>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
            
            // .ForMember(dest => dest.CreatedOn, opt => opt.UseDestinationValue())
        }
    }
}