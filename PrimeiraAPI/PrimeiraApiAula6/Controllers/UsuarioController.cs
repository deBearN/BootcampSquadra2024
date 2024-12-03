using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PrimeiraApiAula6.Models;
using PrimeiraApiAula6.Services;

namespace PrimeiraApiAula6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuariosService usuariosService = new UsuariosService();

        [HttpGet]
        public List<Usuario> Get()
        {
            var usuarios = usuariosService.ObterTodos();

            return usuarios;
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Funcionario")]
        public List<Usuario> Post([FromBody] UsuarioRequest request)
        {
            var usuariosCadastrados = usuariosService.Cadastrar(request.Nome, request.Email);

            return usuariosCadastrados;
        }

        [HttpDelete("{id}")]
        [Authorize]
        public List<Usuario> Delete([FromRoute] int id)
        {

            usuariosService.Remover(id);

            return usuariosService.ObterTodos();
        }

        [HttpPut("{id}")]
        [Authorize]
        public List<Usuario> Atualizar(UsuarioRequest request, [FromRoute] int id)
        {
            usuariosService.Atualizar(id, request.Nome, request.Email);

            return usuariosService.ObterTodos();
        }
    }
}
