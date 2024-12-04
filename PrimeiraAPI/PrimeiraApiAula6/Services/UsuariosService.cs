using PrimeiraApiAula6.Models;

namespace PrimeiraApiAula6.Services
{
    public class UsuariosService
    {
        private static List<Usuario> Usuarios { get; set; } = new List<Usuario>() 
        {
            new Usuario()
            {
                Id = 1,
                Nome = "Felipe",
                Email = "felipe@gmail.com"
            },
            new Usuario()
            {
                Id= 2,
                Nome = "Marcos",
                Email = "Marcos@gmail.com"
            }
        };

        public List<Usuario> ObterTodos()
        {
            return Usuarios;
        }

        public List<Usuario> Cadastrar(UsuarioRequest request)
        {
            var funcaoId = request.FuncaoId;

            //enriquecer o objeto de funcao, buscando a funcao por id

            Usuario usuario = new Usuario()
            {
                Id = Usuarios.Count() + 1,
                Nome = request.Nome,
                Email = request.Email,
                //Funcao = objFuncao
            };

            Usuarios.Add(usuario);

            return ObterTodos();
        }

        public void Remover(int id)
        {
            var usuario = Usuarios.FirstOrDefault(x => x.Id == id);

            if (usuario == null)
                return;

            Usuarios.Remove(usuario);
        }

        public void Atualizar(int id, string nome, string email)
        {
            var usuario = Usuarios.FirstOrDefault(x => x.Id == id);
            usuario.Nome = nome;
            usuario.Email = email;

            Usuarios.Remove(usuario);
            Usuarios.Add(usuario);
        }
    }
}
