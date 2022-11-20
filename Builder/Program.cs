using Builder.Builders;
using Builder.Diretores;
using Builder.Produtor;
using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VeiculoBuilder builder = new();
            Diretor director = new(builder);

            director.ConstruirCarroSedan();

            Veiculo _carroSedan = builder.ObterVeiculo();

            Console.WriteLine($"Criado uma veículo do tipo: {_carroSedan.TipoVeiculo}");

            director.ConstruirTruck();

            Veiculo _truck = builder.ObterVeiculo();

            Console.WriteLine($"Criado uma veículo do tipo: {_truck.TipoVeiculo}");

            Console.ReadLine();
        }
    }
}
