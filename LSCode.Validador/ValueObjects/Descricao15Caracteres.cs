using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao15Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao15Caracteres(string valor, string descritivo)
        {
            Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 15, descritivo, "Conteúdo superior à 15 caracteres"));
        }

        public override string ToString() => Valor;
    }
}