using AutoMapper;
using omniBridge_microservices_register.Data.Dtos;

namespace omniBridge_microservices_register.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<ResultViaCepDto, ResultAddressViaCepDto>();
        }
    }
}
