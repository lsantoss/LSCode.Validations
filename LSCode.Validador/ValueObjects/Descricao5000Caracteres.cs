using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao5000Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao5000Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao2().TamanhoMaximo(valor, 5000, descritivo, "Conteúdo superior à 5000 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}