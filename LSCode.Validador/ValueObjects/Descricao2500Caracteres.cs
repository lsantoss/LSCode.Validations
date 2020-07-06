using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao2500Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao2500Caracteres(string valor, string descritivo)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao2().TamanhoMaximo(valor, 2500, descritivo, "Conteúdo superior à 2500 caracteres"));
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}