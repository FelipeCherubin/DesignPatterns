using FluentBuilder.Componentes;

namespace FluentBuilder.Produtor
{
    class Email
    {
        public string Assunto { get; set; }
        public string Destino { get; set; }
        public string Origem { get; set; }
        public string SenhaTemporaria { get; set; }
        public EmailType TipoEmail { get; set; }
    }
}
