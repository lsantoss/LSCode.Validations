using CodeTeam.Validacoes.ValidacoesNotificacoes;

namespace CodeTeam.Validacoes.ValueObjects
{
    public class Descricao4000Caracteres : Notificadora
    {
        public string Valor { get; private set; }

        public Descricao4000Caracteres(string valor, string descritivo)
        {
            Valor = valor;

            AddNotificacao(new ContratoValidacao().TamanhoMaximo(valor, 4000, descritivo, "Conteúdo superior à 4000 caracteres"));
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}