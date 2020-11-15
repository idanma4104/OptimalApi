using AutoMapper;
using OptimalApi.Models.DataBase;
using OptimalApi.Models.ViewModels;

namespace  OptimalApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        // mappings between model and entity objects
        public AutoMapperProfile()
        {
            CreateMap<User, UserResponse>();

            CreateMap<User, AuthenticateResponse>();

            CreateMap<RegisterRequest, User>();

            CreateMap<CreateRequest, User>();

           
        }
    }
}