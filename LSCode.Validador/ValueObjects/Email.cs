using LSCode.Validador.ValidacoesNotificacoes;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class Email : Notificadora
    {
        public string Valor { get; private set; }

        public Email(string valor)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao().EhVerdadeiro(Validar(Valor), "Email", "Email inválido"));
        }

        public bool Validar(string email)
        {
            return Regex.IsMatch(email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}