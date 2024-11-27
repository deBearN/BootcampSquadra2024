namespace ConsoleAppAula3
{
    public class Cargo
    {
        public string NomeCargo { get; set; }
        public decimal SalarioMin { get; set; }

        public Cargo(string nomeCargo)
        {
            NomeCargo = nomeCargo;
        }
    }
}
