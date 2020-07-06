using LSCode.Validador.ValidacoesNotificacoes;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class Telefone : Notificadora
    {
        public string Valor { get; private set; }

        public Telefone(string valor)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao2().EhVerdadeiro(Validar(Valor), "Telefone", "Telefone inválido"));
        }

        public bool Validar(string telefone)
        {
            return Regex.IsMatch(telefone, @"^([0-9]{2})\s[0-9]{4}-[0-9]{4}$");
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}