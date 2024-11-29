namespace ConsoleAppAula5
{
    public class Usuario
    {
        public void RegistrarUsuario(string nome, int idade)
        {
            try
            {
                if (string.IsNullOrEmpty(nome) || nome.Length < 3)
                {
                    throw new InvalidNameException("O nome de usuario inválido.");
                }

                if (idade < 18)
                {
                    throw new InvalidIdadeException("O usuario deve ter pelo menos 18 anos para se registar.", idade);
                }
            }
            catch (InvalidIdadeException ex)
            {
                Console.WriteLine($"Falha na idade do usuario: \n{ex.Message}" +
                                  $"\n\nIdade informada excedida: {ex.IdadeExcept}");

                throw new InvalidIdadeException(ex.Message, ex);
            }
            catch (InvalidNameException ex)
            {
                Console.WriteLine($"Falha no nome do usuario: \n{ex.Message}");
            }

            Console.WriteLine("Usuário registrado com sucesso!");
        }
    }
}
