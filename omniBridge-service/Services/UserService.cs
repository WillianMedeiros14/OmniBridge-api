using AutoMapper;
using Microsoft.AspNetCore.Identity;
using omniBridge_service.Data.Dtos;
using omniBridge_service.Models;

namespace omniBridge_service.Services
{
    public class UserService
    {
        private IMapper _mapper;
        private UserManager<UserModel> _userManager;
        private SignInManager<UserModel> _signInManager;
        private TokenService _tokenService;

        public UserService(IMapper mapper, UserManager<UserModel> userManager, SignInManager<UserModel> signInManager, TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task<LoginResponseDto> Login(LoginUserDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
            {
                throw new ApplicationException("Usuário não encontrado!");
            }

            var result = await _signInManager.PasswordSignInAsync(user.UserName, dto.Password, false, false);

            if (!result.Succeeded)
            {
                throw new ApplicationException("Usuário ou senha incorretos!");
            }

            var token = _tokenService.GenerateToken(user);

            return new LoginResponseDto
            {
                Token = token,
                User = new UserInfoDto
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email
                }
            };
        }

        public async Task<string> GetUserId(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                throw new ApplicationException("Usuário não encontrado!");
            }

            return user.Id;
        }
    }
}
