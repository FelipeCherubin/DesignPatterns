using Bridge.Plataformas;
using System;

namespace Bridge.Transmissoes
{
    class AdvancedLive : Live
    {
        public AdvancedLive(IPlataforma platform) : base(platform)
        {
        }

        public void Subtitulo()
        {
            Console.WriteLine("Legendas ativadas na transmissão!");
        }

        public void Commentarios()
        {

            Console.WriteLine("Comentários liberados na live.");

        }
    }
}
