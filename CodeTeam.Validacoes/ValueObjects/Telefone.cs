using CodeTeam.Validacoes.ValidacoesNotificacoes;
using System.Text.RegularExpressions;

namespace CodeTeam.Validacoes.ValueObjects
{
    public class Telefone : Notificadora
    {
        public string Valor { get; private set; }

        public Telefone(string valor)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().EhVerdadeiro(Validar(Valor), "Telefone", "Telefone inválido"));
        }

        public bool Validar(string telefone)
        {
            return Regex.IsMatch(telefone, @"^([0-9]{2})\s[0-9]{4}-[0-9]{4}$");
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}