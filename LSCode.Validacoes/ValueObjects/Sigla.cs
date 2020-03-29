using LSCode.Validacoes.ValidacoesNotificacoes;

namespace LSCode.Validacoes.ValueObjects
{
    public class Sigla : Notificadora
    {
        public string Valor { get; private set; }

        public Sigla(string valor)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 3, "Sigla", "Sigla superior à 3 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}