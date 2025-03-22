using AutoMapper;
using Microsoft.AspNetCore.Identity;
using omniBridge_microservices_register.Models;

namespace omniBridge_microservices_register.Services
{
    public class UserService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<UserModel> _userManager;

        public UserService(IMapper mapper, UserManager<UserModel> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<string> SignUp(CreateUserDto dto)
        {
            UserModel user = _mapper.Map<UserModel>(dto);

            IdentityResult result = await _userManager.CreateAsync(user, dto.Password);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Falha ao cadastrar usuário!");
            }

            return "Usuário cadastrado com sucesso!";
        }
    }
}
