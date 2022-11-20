using Builder.Builders;
using Builder.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Diretores
{
    class Diretor
    {
        readonly IBuilder builder;

        public Diretor(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstruirCarroSedan()
        {
            builder.DefinirTipoVeiculo(TipoVeiculo.SEDAN);
            builder.DefinirMotor(new Motor(2000));
            builder.DefinirAssentos(5);
            builder.DefinirTransmissao(Transmissao.AUTOMATIC);
        }

        public void ConstruirTruck()
        {
            builder.DefinirTipoVeiculo(TipoVeiculo.TRUCK);
            builder.DefinirMotor(new Motor(4000));
            builder.DefinirAssentos(2);
            builder.DefinirTransmissao(Transmissao.MANUAL);
        }
    }
}
