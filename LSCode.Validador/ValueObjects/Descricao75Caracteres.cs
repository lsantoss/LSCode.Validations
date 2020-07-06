using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    class Descricao75Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao75Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao2().TamanhoMaximo(valor, 75, descritivo, "Conteúdo superior à 75 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}