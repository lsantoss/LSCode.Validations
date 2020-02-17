using CodeTeam.Validacoes.ValidacoesNotificacoes;

namespace CodeTeam.Validacoes.ValueObjects
{
    public class Descricao250Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao250Caracteres(string valor, string descritivo)
        {
            Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 250, descritivo, "Conteúdo superior à 250 caracteres"));
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}