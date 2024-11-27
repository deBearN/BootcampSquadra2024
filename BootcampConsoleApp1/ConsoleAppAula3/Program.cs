using ConsoleAppAula3;

var funcionario = new Colaborador("João", "Atendente");

funcionario.AumentarSalario(350m);
funcionario.AtualizarTaxa(0.8m);
funcionario.DeduzirImposto();

string mensagem = funcionario.ExibirDados();
Console.WriteLine(mensagem);