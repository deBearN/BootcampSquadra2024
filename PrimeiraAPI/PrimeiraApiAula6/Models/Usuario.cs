namespace PrimeiraApiAula6.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int UserLoginId { get; set; }
        public UserLogin Login { get; set; }
        public int FuncaoId { get; set; }
        public Funcao Funcao { get; set; }
    }
}
