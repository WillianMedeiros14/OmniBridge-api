using AutoMapper;

using omniBridge_microservices_register.Models;

namespace omniBridge_microservices_register.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, UserModel>();
            CreateMap<CreateAddressDto, AddressModel>();
        }
    }
}
