using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using omniBridge_service.Models;

namespace omniBridge_service.Services
{
    public class TokenService
    {
        public string GenerateToken(UserModel user)
        {
            Claim[] claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key.Secret));

            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
                (
                    expires: DateTime.Now.AddDays(10),
                    claims: claims,
                    signingCredentials: signingCredentials
                );


            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
