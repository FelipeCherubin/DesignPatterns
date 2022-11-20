using Builder.Componentes;
using Builder.Produtor;
using System;

namespace Builder.Builders
{
    internal class VeiculoBuilder : IBuilder
    {
        private Veiculo veiculo = new Veiculo();

        public void DefinirAssentos(int assentos)
        {
            veiculo.Assentos = assentos;
        }

        public void DefinirMotor(Motor motor)
        {
            veiculo.Motor = motor;
        }

        public void DefinirTipoVeiculo(TipoVeiculo tipoVeiculo)
        {
            veiculo.TipoVeiculo = tipoVeiculo;
        }

        public void DefinirTransmissao(Transmissao transmissao)
        {
            veiculo.Transmissao = transmissao;
        }

        public Veiculo ObterVeiculo()
        {
            Veiculo resultado = veiculo;
            Reset();
            return resultado;
        }

        public void Reset()
        {
            veiculo = new Veiculo();
        }
    }
}
