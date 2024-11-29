namespace ConsoleAppAula5
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException() { }

        public InvalidNameException(string mensagem) : base(mensagem) { }

        public InvalidNameException(string mensagem, Exception innerException) : base(mensagem, innerException) { }
    }
}
