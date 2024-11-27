namespace ConsoleAppAula2
{
    public class Cachorro : BarulhoEmitido, Animal
    {
        public void Comer()
        {
            Console.WriteLine("O cachorro esta comendo!");
        }

        public void Movimentar()
        {
            Console.WriteLine("O cachorro esta andando!");
        }

        public override void Barulho()
        {
            Console.WriteLine("Cachorro Latindo");
        }
    }
}
