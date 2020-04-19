using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao30Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao30Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 30, descritivo, "Conteúdo superior à 30 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}