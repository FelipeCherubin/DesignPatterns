using FluentBuilder.Componentes;
using FluentBuilder.Produtor;

namespace FluentBuilder.Builders
{
    class EmailBuilder
    {
        readonly Email _email;

        public EmailBuilder()
        {
            _email = new Email();
        }

        public EmailBuilder Assunto(string assunto)
        {
            _email.Assunto = assunto;
            return this;
        }

        public EmailBuilder Destino(string destino)
        {
            _email.Destino = destino;
            return this;
        }

        public EmailBuilder Origem(string origem)
        {
            _email.Origem = origem;
            return this;
        }

        public EmailBuilder SenhaTemporaria(string senhaTemporaria)
        {
            _email.SenhaTemporaria = senhaTemporaria;
            return this;
        }

        public EmailBuilder TipoEmail(EmailType tipoEmail)
        {
            _email.TipoEmail = tipoEmail;
            return this;
        }

        public Email Builder()
        {
            return _email;
        }
    }
}
