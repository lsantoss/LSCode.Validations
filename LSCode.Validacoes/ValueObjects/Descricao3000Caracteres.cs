using LSCode.Validacoes.ValidacoesNotificacoes;

namespace LSCode.Validacoes.ValueObjects
{
    public class Descricao3000Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao3000Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 3000, descritivo, "Conteúdo superior à 3000 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}