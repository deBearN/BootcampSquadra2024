using ApiCRUD.Data;
using ApiCRUD.Models.Usuarios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet] //Read
        public ActionResult<List<Usuario>> GetUsuarios()
        {
            return Ok(_context.Usuario.ToList());
        }

        [HttpGet("{id}")] //Read
        public ActionResult<Usuario> GetUsuario([FromRoute] int id)
        {
            var usuario = _context.Usuario.Find(id);

            if (usuario == null) return NotFound();

            return Ok(usuario);
        }

        [HttpPost] //Create
        public ActionResult<Usuario> CreateUsuario([FromBody] UsuarioRequest request)
        {
            var usuario = new Usuario()
            {
                Nome = request.Nome,
                Email = request.Email,
                Ativo = request.Ativo == true ? "1" : "0"
            };

            _context.Usuario.Add(usuario);
            _context.SaveChanges();

            return Ok(usuario);
        }

        [HttpPut("{id}")] //UPDATE
        public ActionResult<Usuario> UpdateUsuario(
            [FromRoute] int id,
            [FromBody] UsuarioRequest request)
        {
            if (id <= 0) return BadRequest();

            var usuario = new Usuario()
            {
                Id = id,
                Nome = request.Nome,
                Email = request.Email,
                Ativo = request.Ativo == true ? "1" : "0"
            };

            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(usuario);
        }

        [HttpDelete("{id}")] //Delete
        public IActionResult DeleteUsuario([FromRoute] int id)
        {
            if (id <= 0) return BadRequest();

            var usuario = _context.Usuario.Find(id);
            if (usuario == null) return NotFound();

            _context.Usuario.Remove(usuario);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
