using Microsoft.AspNetCore.Mvc;
using omniBridge_microservices_register.Services;
using omniBridge_microservices_register.Models;


namespace omniBridge_microservices_register.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("signUp")]
        public async Task<IActionResult> CreateUser
            (CreateUserDto dto)
        {
            var response = await _userService.SignUp(dto);
            return Ok(response);

        }
    }
}