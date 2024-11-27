using ConsoleAppAula3;

var cargo = new Cargo("Atendente");
var funcionario = new Colaborador("João", cargo);

funcionario.AumentarSalario(350m);
funcionario.AtualizarTaxa(0.8m);
funcionario.DeduzirImposto();

string mensagem = funcionario.ExibirDados();
Console.WriteLine(mensagem);