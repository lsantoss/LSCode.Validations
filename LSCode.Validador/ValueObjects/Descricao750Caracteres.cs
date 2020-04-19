using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao750Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao750Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 750, descritivo, "Conteúdo superior à 750 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}