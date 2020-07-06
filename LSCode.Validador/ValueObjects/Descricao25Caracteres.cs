using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao25Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao25Caracteres(string valor, string descritivo)
        {
            Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 25, descritivo, "Conteúdo superior à 25 caracteres"));
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}