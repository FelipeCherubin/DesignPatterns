using System;

namespace Bridge.Plataformas
{
    public class YouTube : IPlataforma
    {
        public YouTube()
        {
            ConfigureRMTP();
            Console.WriteLine("YouTube: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("YouTube: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("YouTube: Configurando servidor RMTP.");
        }
    }
}
