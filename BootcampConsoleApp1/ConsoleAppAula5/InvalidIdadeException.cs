namespace ConsoleAppAula5
{
    public class InvalidIdadeException : Exception
    {
        public int IdadeExcept { get; set; }

        public InvalidIdadeException() { }
        public InvalidIdadeException(string mensagem) : base(mensagem) { }
        public InvalidIdadeException(string mensagem, Exception innerException) : base(mensagem, innerException) { }
        public InvalidIdadeException(string mensagem, int idade) : base(mensagem) 
        {
            IdadeExcept = idade;
        }
    }
}
