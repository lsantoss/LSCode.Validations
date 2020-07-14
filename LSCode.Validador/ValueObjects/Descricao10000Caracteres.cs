using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao10000Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao10000Caracteres(string valor, string descritivo)
        {
            Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 10000, descritivo, "Conteúdo superior à 10000 caracteres"));
        }

        public override string ToString() => Valor;
    }
}