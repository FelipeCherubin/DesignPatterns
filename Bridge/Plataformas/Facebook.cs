using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataformas
{
    public class Facebook : IPlataforma
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: Configurando servidor RMTP.");
        }
    }
}
