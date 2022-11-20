using FluentBuilder.Builders;
using FluentBuilder.Produtor;
using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Finalizar exemplo
            Email _email = new EmailBuilder()
                .Destino("")
                .Assunto("")
                .Origem("")
                .SenhaTemporaria("")
                .TipoEmail("")
                .Builder();
        }
    }
}
