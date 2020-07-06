using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class UF : Notificadora
    {
        public string Valor { get; private set; }

        public UF(string valor)
        {
            Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 2, "UF", "UF superior à 2 caracteres"));
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}