using Builder.Componentes;
using Builder.Produtor;

namespace Builder.Builders
{
    internal interface IBuilder
    {
        void Reset();
        Veiculo ObterVeiculo();

        void DefinirAssentos(int assentos);
        void DefinirMotor(Motor motor);
        void DefinirTransmissao(Transmissao transmissao);
        void DefinirTipoVeiculo(TipoVeiculo tipoVeiculo);
    }
}
