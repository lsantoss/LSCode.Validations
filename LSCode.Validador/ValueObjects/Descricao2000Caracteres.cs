using LSCode.Validador.ValidacoesNotificacoes;

namespace LSCode.Validador.ValueObjects
{
    public class Descricao2000Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao2000Caracteres(string valor, string descritivo)
        {
            Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 2000, descritivo, "Conteúdo superior à 2000 caracteres"));
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}