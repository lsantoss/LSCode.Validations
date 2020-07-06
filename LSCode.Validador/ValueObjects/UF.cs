using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class UF : Notificadora
    {
        public string Valor { get; private set; }

        public UF(string valor)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao2().TamanhoMaximo(valor, 2, "UF", "UF superior à 3 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}