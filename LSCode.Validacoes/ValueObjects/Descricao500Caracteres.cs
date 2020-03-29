using LSCode.Validacoes.ValidacoesNotificacoes;

namespace LSCode.Validacoes.ValueObjects
{
    public class Descricao500Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao500Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 500, descritivo, "Conteúdo superior à 500 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}