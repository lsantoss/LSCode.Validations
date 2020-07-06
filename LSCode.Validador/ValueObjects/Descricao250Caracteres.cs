using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao250Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao250Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao2().TamanhoMaximo(valor, 250, descritivo, "Conteúdo superior à 250 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}