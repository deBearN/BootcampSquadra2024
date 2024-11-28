using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula4
{
    public abstract class Veiculo
    {
        protected int Velocidade { get; set; } = 0;
        private string Cor { get; set; }

        //Propriedades/Atributos Comuns
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Proprietario { get; set; }

        //Método Comum
        public void ExibirInformacoes(string informacao = null)
        {
            Console.WriteLine($"Marca: {Marca}" +
                              $"\nModelo: {Modelo}" +
                              $"\nAno: {Ano}" +
                              $"\nCor: {Cor}" +
                              $"\nVelocidade: {Velocidade}" +
                              $"\nProprietario: {Proprietario}" +
                              $"\n\tInformações: " + (informacao == null ? "" : informacao));

        }

        //Método abstrato para comportamento Especifico
        public abstract string Acelerar();
        public abstract void AlterarProprietario(string nome);

        public void Frear()
        {
            Console.WriteLine("Veículo Freando");
        }

        public void AlterarCor(string cor)
        {
            Cor = cor;
        }
    }
}
