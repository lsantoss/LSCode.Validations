using CodeTeam.Validacoes.ValidacoesNotificacoes;
using System.Text.RegularExpressions;

namespace CodeTeam.Validacoes.ValueObjects
{
    public class CEP : Notificadora
    {
        public string Valor { get; private set; }

        public CEP(string valor)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().EhVerdadeiro(Validar(Valor), "CEP", "CEP inválido"));
        }

        public bool Validar(string cep)
        {
            return Regex.IsMatch(cep, @"^\d{5}\-?\d{3}$");
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}