using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao400Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao400Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao2().TamanhoMaximo(valor, 400, descritivo, "Conteúdo superior à 400 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}