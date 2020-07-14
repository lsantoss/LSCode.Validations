using LSCode.Validador.ValidacoesNotificacoes;
using System;
using System.Text.RegularExpressions;

namespace LSCode.Validador.ValueObjects
{
    public class Telefone : Notificadora
    {
        public string Valor { get; private set; }

        public Telefone(string valor)
        {
            bool valido = Validar(valor);

            if (valido)
                Valor = Formatar(valor);

            AddNotificacao(new ContratoValidacao().EhVerdadeiro(valido, "Telefone", "Telefone inválido"));
        }

        public bool Validar(string telefone) => Regex.IsMatch(telefone, @"^(\(?)([0-9]{2})(\)?)[0-9]{4}-?[0-9]{4}$");

        private string Formatar(string telefone)
        {
            if(telefone.Length == 13) {
                return telefone;
            }
            else
            {
                telefone = telefone.Trim();
                telefone = telefone.Replace("(", "").Replace(")", "").Replace("-", "");
                telefone = Convert.ToUInt64(telefone).ToString(@"\(00\)0000\-0000");
                return telefone;
            }
        }

        public override string ToString() => Valor;
    }
}