namespace ConsoleAppAula3
{
    public class Colaborador
    {
        public Colaborador(string nome, string cargo)
        {
            Id = Guid.NewGuid(); //UniqueIdentifier 
            Matricula = new Random().Next(1000, 9999); //123154
            DataAdmissao = DateTime.Now;
            Nome = nome;
            Cargo = cargo;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public decimal SalarioAtualizado { get; set; }
        public int Matricula { get; set; }
        public decimal Taxa { get; set; } = 0.5m;
        public string Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }

        public void AumentarSalario(decimal valor)
        {
            Salario += valor;
        }

        public string ExibirDados()
        {
            return $"{Id} \nO {Cargo} {Nome} " +
                   $"\nMatricula: {Matricula}" +
                   $"\ncom o Salario base {Salario}" +
                   $"\nSalario deduzido {SalarioAtualizado}";
        }

        public void DeduzirImposto()
        {
            SalarioAtualizado = Salario - (Salario * (Taxa / 100));
        }

        public void AtualizarTaxa(decimal novaTaxa)
        {
            Taxa = novaTaxa;
        }
    }
}
