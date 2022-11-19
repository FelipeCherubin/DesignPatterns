using System;

namespace Bridge.Plataformas
{
    public class TwitchTV : IPlataforma
    {
        public TwitchTV()
        {
            ConfigureRMTP();
            Console.WriteLine("TwitchTV: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("TwitchTV: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTV: Configurando servidor RMTP.");
        }
    }
}
