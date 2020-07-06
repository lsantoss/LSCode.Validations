using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Sigla : Notificadora
    {
        public string Valor { get; private set; }

        public Sigla(string valor)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao2().TamanhoMaximo(valor, 3, "Sigla", "Sigla superior à 3 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}