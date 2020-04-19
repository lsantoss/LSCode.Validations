using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao1500Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao1500Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 1500, descritivo, "Conteúdo superior à 1500 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}