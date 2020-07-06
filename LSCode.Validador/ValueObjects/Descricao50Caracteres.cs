using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao50Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao50Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao2().TamanhoMaximo(valor, 50, descritivo, "Conteúdo superior à 50 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}