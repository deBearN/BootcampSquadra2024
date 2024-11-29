using ConsoleAppAula5;

decimal v1 = 5;
decimal divisor = 0;

try
{
    Usuario usuario = new Usuario();
    usuario.RegistrarUsuario("Pedro", 15);

    var resultado = v1 / divisor;
}
catch (Exception ex)
{
    Console.WriteLine("Erro generico.");
}

Console.WriteLine($"\n\nFim da execução do programa!");