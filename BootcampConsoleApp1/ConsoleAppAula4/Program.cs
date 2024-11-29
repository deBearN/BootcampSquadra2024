//See https://aka.ms/new-console-template for more information
using ConsoleAppAula4;

Carro carro = new Carro()
{
    Marca = "Nissan",
    Modelo = "Frontier",
    Ano = 2023,
    QuantidadePortas = 4
};

string info = carro.Acelerar();
carro.AlterarCor("Vermelho");
carro.AlterarProprietario("Pedro");
carro.ExibirInformacoes(info);
carro.Terreno($"\nTereno: Lama\n");
