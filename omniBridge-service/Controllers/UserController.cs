using Microsoft.AspNetCore.Mvc;
using omniBridge_service.Data.Dtos;
using omniBridge_service.Services;

namespace omniBridge_service.Controllers
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


        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginUserDto dto)
        {
            try
            {
                var token = await _userService.Login(dto);
                return Ok(token);
            }
            catch (ApplicationException ex)
            {
                return Unauthorized(new { message = ex.Message });
            }
        }

    }
}