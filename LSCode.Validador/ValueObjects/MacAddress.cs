using LSCode.Validador.ValidacoesNotificacoes;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class MacAddress : Notificadora
    {
        public string Valor { get; private set; }

        public MacAddress(string valor)
        {
            this.Valor = valor;

            AddNotificacao(new ContratoValidacao2().EhVerdadeiro(Validar(Valor), "Mac Address", "Mac Address inválido"));
        }

        public bool Validar(string valor)
        {
            return Regex.IsMatch(valor, @"^(?:[0-9a-fA-F]{2}:){5}[0-9a-fA-F]{2}|(?:[0-9a-fA-F]{2}-){5}[0-9a-fA-F]{2}$");
        }

        public override string ToString()
        {
            return this.Valor;
        }
    }
}