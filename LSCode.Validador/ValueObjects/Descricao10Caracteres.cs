using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao10Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao10Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 10, descritivo, "Conteúdo superior à 10 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}