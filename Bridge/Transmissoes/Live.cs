using Bridge.Plataformas;
using System;

namespace Bridge.Transmissoes
{
    class Live : ITransmissao
    {
        protected IPlataforma platform;
        public Live(IPlataforma platform)
        {
            this.platform = platform;
        }

        public void Resultado()
        {
            Console.WriteLine($"Inciando a transmissão na {platform}");
        }

        public void Transmissao()
        {
            Console.WriteLine("**** ON AIR ****");
        }
    }
}
