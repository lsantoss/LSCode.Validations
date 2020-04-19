namespace LSCode.Validador.ValidacoesNotificacoes
{
    public sealed class Notificacao
    {
        public string Propriedade { get; }
        public string Mensagem { get; }


        public Notificacao(string propriedade, string mensagem)
        {
            this.Propriedade = propriedade;
            this.Mensagem = mensagem;
        }
    }
}