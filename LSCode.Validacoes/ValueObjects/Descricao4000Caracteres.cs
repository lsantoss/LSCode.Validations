using LSCode.Validacoes.ValidacoesNotificacoes;

namespace LSCode.Validacoes.ValueObjects
{
    public class Descricao4000Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao4000Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 4000, descritivo, "Conteúdo superior à 4000 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}