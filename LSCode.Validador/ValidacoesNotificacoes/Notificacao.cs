namespace LSCode.Validador.ValidacoesNotificacoes
{
    /// <summary>Auxilia na criação de notificações.</summary>
    public sealed class Notificacao
    {
        /// <value>Propriedade da notificação.</value>
        public string Propriedade { get; }

        /// <value>Mensagem da notificação.</value>
        public string Mensagem { get; }

        /// <summary>Construtor da classe Notificacao.</summary>
        /// <param name="propriedade">Propriedade da notificação.</param>
        /// <param name="mensagem">Mensagem da notificação.</param>
        /// <returns> Cria uma instância da classe Notificacao.</returns>
        public Notificacao(string propriedade, string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }
    }
}