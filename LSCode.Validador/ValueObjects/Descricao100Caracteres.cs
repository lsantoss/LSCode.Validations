using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao100Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao100Caracteres(string valor, string descritivo)
        {
            Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 100, descritivo, "Conteúdo superior à 100 caracteres"));
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}