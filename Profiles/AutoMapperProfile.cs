using System;
using Activity.Data.Create;
using Activity.Data.Read;
using Activity.Models;
using AutoMapper;

namespace Activity.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            var date = DateTime.Now;
            CreateMap<ActivityModel, ActivityDto>();
            CreateMap<UsersModel, UserDto>();
            CreateMap<ActivityCreateDto, ActivityModel>()
            .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
            .ForMember(dest => dest.LastModified, opt => opt.MapFrom(src => DateTime.UtcNow));
        }
    }
}