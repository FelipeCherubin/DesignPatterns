using FluentBuilder.Builders;
using FluentBuilder.Componentes;
using FluentBuilder.Produtor;
using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Email _emailPrimeiroCadastroUsuario = new EmailBuilder()
                .Destino("primeiro.usuario@gmail.com")
                .Assunto("cadastro de Usuario")
                .Origem("sistema_contato@gmail.com")
                .SenhaTemporaria(Guid.NewGuid().ToString().Substring(0, 5))
                .TipoEmail(EmailType.CadastroUsuario)
                .Builder();

            Console.WriteLine($"Tipo de email: {_emailPrimeiroCadastroUsuario.TipoEmail}");

            Email _emailAlteracaoDeSenha = new EmailBuilder()
                .Destino("primeiro.usuario@gmail.com")
                .Assunto("alteração de senha")
                .Origem("sistema_contato@gmail.com")
                .TipoEmail(EmailType.AlteracaoSenha)
                .Builder();

            Console.WriteLine($"Tipo de email: {_emailAlteracaoDeSenha.TipoEmail}");


            Console.ReadLine();
        }
    }
}
