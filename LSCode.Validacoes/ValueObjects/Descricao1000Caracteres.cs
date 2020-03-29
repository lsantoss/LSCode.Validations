using LSCode.Validacoes.ValidacoesNotificacoes;

namespace LSCode.Validacoes.ValueObjects
{
    public class Descricao1000Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao1000Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 1000, descritivo, "Conteúdo superior à 1000 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}