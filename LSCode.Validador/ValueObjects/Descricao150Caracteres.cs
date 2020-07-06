using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao150Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao150Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao2().TamanhoMaximo(valor, 150, descritivo, "Conteúdo superior à 150 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}