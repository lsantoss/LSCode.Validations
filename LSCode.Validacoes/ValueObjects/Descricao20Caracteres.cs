using LSCode.Validacoes.ValidacoesNotificacoes;

namespace LSCode.Validacoes.ValueObjects
{
    public class Descricao20Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao20Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 20, descritivo, "Conteúdo superior à 20 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}