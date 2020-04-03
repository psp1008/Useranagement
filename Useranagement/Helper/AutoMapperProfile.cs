using AutoMapper;
using Useranagement.Dtos;
using Useranagement.Entities;

namespace Useranagement.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}