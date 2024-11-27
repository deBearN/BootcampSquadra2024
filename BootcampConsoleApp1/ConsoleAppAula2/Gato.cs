namespace ConsoleAppAula2
{
    public class Gato : BarulhoEmitido, Animal
    {
        public void Comer()
        {
            Console.WriteLine("O gato esta comendo!");
        }

        public void Movimentar()
        {
            Console.WriteLine("O gato esta se movimentando!");
        }
    }
}
