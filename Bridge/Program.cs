using Bridge.Plataformas;
using Bridge.Transmissoes;
using System;

namespace Bridge
{
    class Program
    {
        static void IniciarLiveAdvanced(IPlataforma platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new(platform);

            live.Transmissao();
            live.Subtitulo();
            live.Commentarios();
            live.Resultado();
        }

        static void Main(string[] args)
        {
            IniciarLiveAdvanced(new YouTube());
            IniciarLiveAdvanced(new Facebook());
            IniciarLiveAdvanced(new TwitchTV());

            Console.ReadLine();
        }
    }
}
