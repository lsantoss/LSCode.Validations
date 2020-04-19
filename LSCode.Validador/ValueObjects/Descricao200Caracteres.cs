using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao200Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao200Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 200, descritivo, "Conteúdo superior à 200 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}