using AutoMapper;
using kilit_data.Data.Dto;
using kilit_data.Data.Entity;
using kilit_data.Data.Model;

namespace kilit_data.Data.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<SignupRequest, User>();
        }
    }
}
