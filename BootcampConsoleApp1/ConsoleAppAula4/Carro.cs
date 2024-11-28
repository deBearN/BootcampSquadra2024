using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAula4
{
    public class Carro : Veiculo, ITerrestre
    {
        public int QuantidadePortas { get; set; }

        public override string Acelerar()
        {
            Velocidade++;
            return "O carro esta acelerando...";
        }

        public override void AlterarProprietario(string nome)
        {
            Proprietario = nome;
        }

        public string Terreno(string tipo)
        {
            return tipo;
        }


    }
}
