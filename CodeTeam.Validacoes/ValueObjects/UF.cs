using CodeTeam.Validacoes.ValidacoesNotificacoes;

namespace CodeTeam.Validacoes.ValueObjects
{
    public class UF : Notificadora
    {
        public string Valor { get; private set; }

        public UF(string valor)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 2, "UF", "UF superior à 3 caracteres"));
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}