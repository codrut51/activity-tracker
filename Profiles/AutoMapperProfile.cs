using Activity.Data;
using Activity.Models;
using AutoMapper;

namespace Activity.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ActivityModel, ActivityDto>();
            CreateMap<UsersModel, UserDto>();
        }
    }
}