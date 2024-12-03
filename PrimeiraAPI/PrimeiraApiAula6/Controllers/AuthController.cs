using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PrimeiraApiAula6.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PrimeiraApiAula6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] UserLogin login)
        {
            if (login.UserName.Equals("Administrador") && login.Password.Equals("123456"))
            {
                var token = GerarTokenJWT();
                return Ok(new { Token = token });
            }

            return Unauthorized(new { Mensagem = "Credenciais Invalidas", Codigo = 001 });
        }

        [HttpGet("RotaProtegida")]
        [Authorize]
        public IActionResult RotaProtegida()
        {
            return Ok("Acessando uma rota Protegida");
        }

        private string GerarTokenJWT()
        {
            var claims = new[]
            {
                //new Claim(ClaimTypes.Name,"Administrador"), //Nome do Usuario
                new Claim(ClaimTypes.Role,"Admin") // Papel do usuario
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("93f8207bc2281eebd070f337f907984bfb4ef2d3f1b08689e2e7e16030c8c5e9"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
                (
                issuer: "api-autenticacao",
                audience: "api-cadastro",
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
