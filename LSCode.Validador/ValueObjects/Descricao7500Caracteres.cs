using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao7500Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao7500Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao2().TamanhoMaximo(valor, 7500, descritivo, "Conteúdo superior à 7500 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}